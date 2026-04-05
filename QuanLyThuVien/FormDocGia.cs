using System;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormDocGia : Form
    {
        Database db = new Database();

        public FormDocGia()
        {
            InitializeComponent();
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            txtMaDocGia.ReadOnly = true;
            UIHelper.StyleDataGridView(dgvDocGia);
        }

        void LoadDocGia()
        {
            dgvDocGia.DataSource = db.ExecuteQuery("SELECT * FROM DocGia");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO DocGia(HoTen, SoDienThoai, DiaChi) VALUES (N'{txtHoTen.Text}', N'{txtSoDienThoai.Text}', N'{txtDiaChi.Text}')";
            db.ExecuteNonQuery(query);
            LoadDocGia();
            MessageBox.Show("Thêm độc giả thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE DocGia SET HoTen=N'{txtHoTen.Text}', SoDienThoai=N'{txtSoDienThoai.Text}', DiaChi=N'{txtDiaChi.Text}' WHERE MaDocGia={txtMaDocGia.Text}";
            db.ExecuteNonQuery(query);
            LoadDocGia();
            MessageBox.Show("Sửa độc giả thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM DocGia WHERE MaDocGia={txtMaDocGia.Text}";
            db.ExecuteNonQuery(query);
            LoadDocGia();
            MessageBox.Show("Xóa độc giả thành công!");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDocGia.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaDocGia.Text = dgvDocGia.Rows[e.RowIndex].Cells["MaDocGia"].Value.ToString();
                txtHoTen.Text = dgvDocGia.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                txtSoDienThoai.Text = dgvDocGia.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = dgvDocGia.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}