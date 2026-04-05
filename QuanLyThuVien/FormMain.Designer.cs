namespace QuanLyThuVien
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSachItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDocGiaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMuonTraItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoiMatKhauItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuatItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalSachVal = new System.Windows.Forms.Label();
            this.lblTotalSachDesc = new System.Windows.Forms.Label();
            this.lblDangMuonVal = new System.Windows.Forms.Label();
            this.lblDangMuonDesc = new System.Windows.Forms.Label();
            this.lblQuaHanVal = new System.Windows.Forms.Label();
            this.lblQuaHanDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(599, 380);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(180, 55);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.FormMain_Load);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(207, 380);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(180, 55);
            this.btnDoiMatKhau.TabIndex = 1;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu ";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(599, 290);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(180, 55);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Location = new System.Drawing.Point(207, 290);
            this.btnMuonTra.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(180, 55);
            this.btnMuonTra.TabIndex = 3;
            this.btnMuonTra.Text = "Mượn trả sách ";
            this.btnMuonTra.UseVisualStyleBackColor = true;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Location = new System.Drawing.Point(599, 200);
            this.btnDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(180, 55);
            this.btnDocGia.TabIndex = 4;
            this.btnDocGia.Text = "Quản lý độc giả";
            this.btnDocGia.UseVisualStyleBackColor = true;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnSach
            // 
            this.btnSach.Location = new System.Drawing.Point(207, 200);
            this.btnSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(180, 55);
            this.btnSach.TabIndex = 5;
            this.btnSach.Text = "Quản lý sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.Location = new System.Drawing.Point(259, 29);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(426, 45);
            this.lblTieuDe.TabIndex = 6;
            this.lblTieuDe.Text = "Hệ thống quản lý thư viện";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(326, 93);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(279, 23);
            this.lblMoTa.TabIndex = 7;
            this.lblMoTa.Text = "Quản lý sách - độc giả - mượn trả";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLy,
            this.menuBaoCao,
            this.menuTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSachItem,
            this.menuDocGiaItem,
            this.menuMuonTraItem});
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(75, 24);
            this.menuQuanLy.Text = "Quản lý";
            // 
            // menuSachItem
            // 
            this.menuSachItem.Name = "menuSachItem";
            this.menuSachItem.Size = new System.Drawing.Size(146, 26);
            this.menuSachItem.Text = "Sách";
            this.menuSachItem.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // menuDocGiaItem
            // 
            this.menuDocGiaItem.Name = "menuDocGiaItem";
            this.menuDocGiaItem.Size = new System.Drawing.Size(146, 26);
            this.menuDocGiaItem.Text = "Độc giả";
            this.menuDocGiaItem.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // menuMuonTraItem
            // 
            this.menuMuonTraItem.Name = "menuMuonTraItem";
            this.menuMuonTraItem.Size = new System.Drawing.Size(146, 26);
            this.menuMuonTraItem.Text = "Mượn trả";
            this.menuMuonTraItem.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThongKeItem});
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(78, 24);
            this.menuBaoCao.Text = "Báo cáo";
            // 
            // menuThongKeItem
            // 
            this.menuThongKeItem.Name = "menuThongKeItem";
            this.menuThongKeItem.Size = new System.Drawing.Size(147, 26);
            this.menuThongKeItem.Text = "Thống kê";
            this.menuThongKeItem.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoiMatKhauItem,
            this.menuDangXuatItem});
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(93, 24);
            this.menuTaiKhoan.Text = "Tài khoản";
            // 
            // menuDoiMatKhauItem
            // 
            this.menuDoiMatKhauItem.Name = "menuDoiMatKhauItem";
            this.menuDoiMatKhauItem.Size = new System.Drawing.Size(199, 26);
            this.menuDoiMatKhauItem.Text = "Đổi mật khẩu";
            this.menuDoiMatKhauItem.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // menuDangXuatItem
            // 
            this.menuDangXuatItem.Name = "menuDangXuatItem";
            this.menuDangXuatItem.Size = new System.Drawing.Size(199, 26);
            this.menuDangXuatItem.Text = "Đăng xuất";
            this.menuDangXuatItem.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // Dashboard labels
            // 
            this.lblTotalSachVal.AutoSize = true;
            this.lblTotalSachVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalSachVal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotalSachVal.Location = new System.Drawing.Point(150, 120);
            this.lblTotalSachVal.Name = "lblTotalSachVal";
            this.lblTotalSachVal.Size = new System.Drawing.Size(46, 46);
            this.lblTotalSachVal.TabIndex = 9;
            this.lblTotalSachVal.Text = "0";
            this.lblTotalSachDesc.AutoSize = true;
            this.lblTotalSachDesc.Location = new System.Drawing.Point(150, 160);
            this.lblTotalSachDesc.Name = "lblTotalSachDesc";
            this.lblTotalSachDesc.Size = new System.Drawing.Size(120, 23);
            this.lblTotalSachDesc.TabIndex = 10;
            this.lblTotalSachDesc.Text = "Tổng số sách";

            this.lblDangMuonVal.AutoSize = true;
            this.lblDangMuonVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDangMuonVal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDangMuonVal.Location = new System.Drawing.Point(420, 120);
            this.lblDangMuonVal.Name = "lblDangMuonVal";
            this.lblDangMuonVal.Size = new System.Drawing.Size(46, 46);
            this.lblDangMuonVal.TabIndex = 11;
            this.lblDangMuonVal.Text = "0";
            this.lblDangMuonDesc.AutoSize = true;
            this.lblDangMuonDesc.Location = new System.Drawing.Point(420, 160);
            this.lblDangMuonDesc.Name = "lblDangMuonDesc";
            this.lblDangMuonDesc.Size = new System.Drawing.Size(143, 23);
            this.lblDangMuonDesc.TabIndex = 12;
            this.lblDangMuonDesc.Text = "Số người đang mượn";

            this.lblQuaHanVal.AutoSize = true;
            this.lblQuaHanVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblQuaHanVal.ForeColor = System.Drawing.Color.IndianRed;
            this.lblQuaHanVal.Location = new System.Drawing.Point(700, 120);
            this.lblQuaHanVal.Name = "lblQuaHanVal";
            this.lblQuaHanVal.Size = new System.Drawing.Size(46, 46);
            this.lblQuaHanVal.TabIndex = 13;
            this.lblQuaHanVal.Text = "0";
            this.lblQuaHanDesc.AutoSize = true;
            this.lblQuaHanDesc.Location = new System.Drawing.Point(700, 160);
            this.lblQuaHanDesc.Name = "lblQuaHanDesc";
            this.lblQuaHanDesc.Size = new System.Drawing.Size(110, 23);
            this.lblQuaHanDesc.TabIndex = 14;
            this.lblQuaHanDesc.Text = "Sách quá hạn";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lblQuaHanDesc);
            this.Controls.Add(this.lblQuaHanVal);
            this.Controls.Add(this.lblDangMuonDesc);
            this.Controls.Add(this.lblDangMuonVal);
            this.Controls.Add(this.lblTotalSachDesc);
            this.Controls.Add(this.lblTotalSachVal);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnSach);
            this.Controls.Add(this.btnDocGia);
            this.Controls.Add(this.btnMuonTra);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnSach;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuSachItem;
        private System.Windows.Forms.ToolStripMenuItem menuDocGiaItem;
        private System.Windows.Forms.ToolStripMenuItem menuMuonTraItem;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuThongKeItem;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhauItem;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuatItem;
        private System.Windows.Forms.Label lblTotalSachVal;
        private System.Windows.Forms.Label lblTotalSachDesc;
        private System.Windows.Forms.Label lblDangMuonVal;
        private System.Windows.Forms.Label lblDangMuonDesc;
        private System.Windows.Forms.Label lblQuaHanVal;
        private System.Windows.Forms.Label lblQuaHanDesc;
    }
}