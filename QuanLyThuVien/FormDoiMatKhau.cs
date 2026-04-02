using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormDoiMatKhau : Form
    {
        Database db = new Database();

        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();

            if (tenDangNhap == "" || matKhauCu == "" || matKhauMoi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string queryCheck = $"SELECT * FROM TaiKhoan WHERE TenDangNhap = N'{tenDangNhap}' AND MatKhau = N'{matKhauCu}'";
            DataTable dt = db.ExecuteQuery(queryCheck);

            if (dt.Rows.Count > 0)
            {
                string queryUpdate = $"UPDATE TaiKhoan SET MatKhau = N'{matKhauMoi}' WHERE TenDangNhap = N'{tenDangNhap}'";
                db.ExecuteNonQuery(queryUpdate);
                MessageBox.Show("Đổi mật khẩu thành công!");
                txtMatKhauCu.Clear();
                txtMatKhauMoi.Clear();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu cũ!");
            }
        }
    }
}