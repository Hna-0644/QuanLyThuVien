using System;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormThongKe : Form
    {
        Database db = new Database();

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btnDangMuon_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = db.ExecuteQuery(
                "SELECT * FROM MuonTra WHERE TrangThai = N'Đang mượn'"
            );
        }

        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = db.ExecuteQuery(
                "SELECT * FROM MuonTra WHERE NgayTra < GETDATE() AND TrangThai = N'Đang mượn'"
            );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}