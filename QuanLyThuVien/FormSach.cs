using System;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormSach : Form
    {
        Database db = new Database();

        public FormSach()
        {
            InitializeComponent();
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            LoadDanhSachSach();
            txtMaSach.ReadOnly = true;
        }

        void LoadDanhSachSach()
        {
            dgvSach.DataSource = db.ExecuteQuery("SELECT * FROM Sach");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Trim() == "" ||
                txtTacGia.Text.Trim() == "" ||
                txtTheLoai.Text.Trim() == "" ||
                txtGia.Text.Trim() == "" ||
                txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            int Gia;
            if (!int.TryParse(txtGia.Text.Trim(), out Gia))
            {
                MessageBox.Show("Gia phải là số!");
                return;
            }

            int soLuong;
            if (!int.TryParse(txtSoLuong.Text.Trim(), out soLuong))
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }

            string query = $@"INSERT INTO Sach (TenSach, TacGia, TheLoai, SoLuong)
        VALUES (N'{txtTenSach.Text.Trim()}',
                N'{txtTacGia.Text.Trim()}',
                N'{txtTheLoai.Text.Trim()}',
                {soLuong})";

            db.ExecuteNonQuery(query);

            MessageBox.Show("Thêm sách thành công!");
            LoadDanhSachSach();
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtSoLuong.Clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvSach.SelectedRows.Count > 0)
            {
                // Lấy thông tin sách từ DataGridView
                int maSach = int.Parse(dgvSach.SelectedRows[0].Cells["MaSach"].Value.ToString());
                string tenSach = txtTenSach.Text;
                string tacGia = txtTacGia.Text;
                string theLoai = txtTheLoai.Text;

                // Kiểm tra số lượng nhập vào có hợp lệ không
                int soLuong;
                if (!int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    MessageBox.Show("Số lượng phải là một số hợp lệ.");
                    return;
                }

                // Kiểm tra giá nhập vào có hợp lệ không
                double gia;
                if (!double.TryParse(txtGia.Text, out gia))
                {
                    MessageBox.Show("Giá phải là một số hợp lệ.");
                    return;
                }

                // Cập nhật thông tin sách vào database
                string query = $"UPDATE Sach SET TenSach = N'{tenSach}', TacGia = N'{tacGia}', TheLoai = N'{theLoai}', SoLuong = {soLuong}, Gia = {gia} WHERE MaSach = {maSach}";
                db.ExecuteNonQuery(query);

                // Cập nhật lại dữ liệu trong DataGridView
                dgvSach.SelectedRows[0].Cells["TenSach"].Value = tenSach;
                dgvSach.SelectedRows[0].Cells["TacGia"].Value = tacGia;
                dgvSach.SelectedRows[0].Cells["TheLoai"].Value = theLoai;
                dgvSach.SelectedRows[0].Cells["SoLuong"].Value = soLuong;
                dgvSach.SelectedRows[0].Cells["Gia"].Value = gia;

                MessageBox.Show("Sửa thông tin sách thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn trong DataGridView
            if (dgvSach.SelectedRows.Count > 0)
            {
                // Lấy mã sách từ dòng đã chọn
                int maSach = int.Parse(dgvSach.SelectedRows[0].Cells["MaSach"].Value.ToString());

                // Câu lệnh SQL xóa sách khỏi database
                string query = $"DELETE FROM Sach WHERE MaSach = {maSach}";
                db.ExecuteNonQuery(query);

                // Xóa dòng khỏi DataGridView
                dgvSach.Rows.RemoveAt(dgvSach.SelectedRows[0].Index);

                MessageBox.Show("Xóa sách thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Làm mới các TextBox
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtSoLuong.Clear();

            // Tải lại danh sách sách (nếu cần)
            LoadDanhSachSach();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSach.Text = dgvSach.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                txtTenSach.Text = dgvSach.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();
                txtTacGia.Text = dgvSach.Rows[e.RowIndex].Cells["TacGia"].Value.ToString();
                txtTheLoai.Text = dgvSach.Rows[e.RowIndex].Cells["TheLoai"].Value.ToString();
                txtSoLuong.Text = dgvSach.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                txtSoLuong.Text = dgvSach.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
            }
        }

        private void txtTheLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}