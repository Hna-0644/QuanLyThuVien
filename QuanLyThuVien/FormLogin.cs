using System;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = textBox1.Text.Trim();
            string matKhau = textBox2.Text.Trim();
            if (tenDangNhap == "admin" && matKhau == "123")
            {
                MessageBox.Show("Đăng nhập thành công!");
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}