namespace QuanLyThuVien
{
    partial class FormThongKe
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
            this.btnQuaHan = new System.Windows.Forms.Button();
            this.btnDangMuon = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuaHan
            // 
            this.btnQuaHan.Location = new System.Drawing.Point(574, 81);
            this.btnQuaHan.Name = "btnQuaHan";
            this.btnQuaHan.Size = new System.Drawing.Size(75, 23);
            this.btnQuaHan.TabIndex = 0;
            this.btnQuaHan.Text = "Quá Hạn ";
            this.btnQuaHan.UseVisualStyleBackColor = true;
            // 
            // btnDangMuon
            // 
            this.btnDangMuon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDangMuon.Location = new System.Drawing.Point(162, 81);
            this.btnDangMuon.Name = "btnDangMuon";
            this.btnDangMuon.Size = new System.Drawing.Size(93, 23);
            this.btnDangMuon.TabIndex = 1;
            this.btnDangMuon.Text = "Đang Mượn ";
            this.btnDangMuon.UseVisualStyleBackColor = true;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(51, 190);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(701, 244);
            this.dgvThongKe.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(700, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDangMuon);
            this.Controls.Add(this.btnQuaHan);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuaHan;
        private System.Windows.Forms.Button btnDangMuon;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnBack;
    }
}