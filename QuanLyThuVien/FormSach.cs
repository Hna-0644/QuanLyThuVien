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
                txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
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
            string query = $"UPDATE Sach SET TenSach=N'{txtTenSach.Text}', TacGia=N'{txtTacGia.Text}', TheLoai=N'{txtTheLoai.Text}', SoLuong={txtSoLuong.Text} WHERE MaSach={txtMaSach.Text}";
            db.ExecuteNonQuery(query);
            LoadDanhSachSach();
            MessageBox.Show("Sửa sách thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM Sach WHERE MaSach={txtMaSach.Text}";
            db.ExecuteNonQuery(query);
            LoadDanhSachSach();
            MessageBox.Show("Xóa sách thành công!");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtSoLuong.Clear();
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
            }
        }

        private void txtTheLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}