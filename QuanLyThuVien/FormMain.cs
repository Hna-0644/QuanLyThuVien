using System;
using System.Drawing;
using System.Windows.Forms;
namespace QuanLyThuVien
{
    public partial class FormMain : Form
    {
        Database db = new Database();
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
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
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

            // assign simple icons from SystemIcons for visual improvement
            try
            {
                btnSach.Image = System.Drawing.SystemIcons.Application.ToBitmap();
                btnDocGia.Image = System.Drawing.SystemIcons.Information.ToBitmap();
                btnMuonTra.Image = System.Drawing.SystemIcons.Asterisk.ToBitmap();
                btnThongKe.Image = System.Drawing.SystemIcons.Question.ToBitmap();
                btnDoiMatKhau.Image = System.Drawing.SystemIcons.Shield.ToBitmap();
                btnDangXuat.Image = System.Drawing.SystemIcons.Error.ToBitmap();
            }
            catch { }

            // set MenuStrip as main menu if present
            try { this.MainMenuStrip = this.menuStrip1; } catch { }

            LoadDashboardCounts();
        }

        private void LoadDashboardCounts()
        {
            try
            {
                var dt1 = db.ExecuteQuery("SELECT COUNT(*) AS c FROM Sach");
                if (dt1.Rows.Count > 0) lblTotalSachVal.Text = dt1.Rows[0][0].ToString();

                var dt2 = db.ExecuteQuery("SELECT COUNT(*) AS c FROM MuonTra WHERE TrangThai = N'Đang mượn'");
                if (dt2.Rows.Count > 0) lblDangMuonVal.Text = dt2.Rows[0][0].ToString();

                var dt3 = db.ExecuteQuery("SELECT COUNT(*) AS c FROM MuonTra WHERE NgayTra < GETDATE() AND TrangThai = N'Đang mượn'");
                if (dt3.Rows.Count > 0) lblQuaHanVal.Text = dt3.Rows[0][0].ToString();
            }
            catch { }
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