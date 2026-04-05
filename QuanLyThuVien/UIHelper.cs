using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    internal static class UIHelper
    {
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 126, 34);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);
        }
    }
}
