using System;
using System.Drawing;
using System.Windows.Forms;
namespace QuanLyThuVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void StyleButton(Button btn, Color color)
        {
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10);

            StyleButton(btnSach, Color.SteelBlue);
            StyleButton(btnDocGia, Color.MediumSeaGreen);
            StyleButton(btnMuonTra, Color.Goldenrod);
            StyleButton(btnThongKe, Color.MediumPurple);
            StyleButton(btnDoiMatKhau, Color.SlateGray);
            StyleButton(btnDangXuat, Color.IndianRed);
        }
        private void btnSach_Click(object sender, EventArgs e)
        {
            new FormSach().ShowDialog();
        }
        private void btnDocGia_Click(object sender, EventArgs e)
        {
            new FormDocGia().ShowDialog();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            new FormMuonTra().ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            new FormThongKe().ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            new FormDoiMatKhau().ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}