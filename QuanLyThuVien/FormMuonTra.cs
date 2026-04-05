using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormMuonTra : Form
    {
        Database db = new Database();

        public FormMuonTra()
        {
            InitializeComponent();
        }

        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            LoadSach();
            LoadMuonTra();

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đang mượn");
            cboTrangThai.Items.Add("Đã trả");

            UIHelper.StyleDataGridView(dgvMuonTra);
        }

        void LoadDocGia()
        {
            DataTable dt = db.ExecuteQuery("SELECT * FROM DocGia");
            cboDocGia.DataSource = dt;
            cboDocGia.DisplayMember = "HoTen";
            cboDocGia.ValueMember = "MaDocGia";
        }

        void LoadSach()
        {
            DataTable dt = db.ExecuteQuery("SELECT * FROM Sach");
            cboSach.DataSource = dt;
            cboSach.DisplayMember = "TenSach";
            cboSach.ValueMember = "MaSach";
        }

        void LoadMuonTra()
        {
            string query = @"SELECT MaMuon, DocGia.HoTen, Sach.TenSach, NgayMuon, NgayTra, TrangThai
                             FROM MuonTra
                             INNER JOIN DocGia ON MuonTra.MaDocGia = DocGia.MaDocGia
                             INNER JOIN Sach ON MuonTra.MaSach = Sach.MaSach";
            dgvMuonTra.DataSource = db.ExecuteQuery(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = $@"INSERT INTO MuonTra(MaDocGia, MaSach, NgayMuon, NgayTra, TrangThai)
                              VALUES ({cboDocGia.SelectedValue}, {cboSach.SelectedValue},
                              '{dtNgayMuon.Value:yyyy-MM-dd}', '{dtNgayTra.Value:yyyy-MM-dd}', N'{cboTrangThai.Text}')";

            db.ExecuteNonQuery(query);
            LoadMuonTra();
            MessageBox.Show("Thêm phiếu mượn trả thành công!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}