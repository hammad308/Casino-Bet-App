using Casino_Bet_And_Win;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Casino_Bet_App
{
    public partial class ReportForm : Form
    {
        PrintDocument pd = new PrintDocument();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            dgvReport.AutoGenerateColumns = true;
            dgvReport.DataSource = ClassforObjects.Reports;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            pd.PrintPage += Pd_PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 20;
            e.Graphics.DrawString("Casino Game Report",
                new Font("Arial", 16, FontStyle.Bold),
                Brushes.Black, 200, y);

            y += 40;

            foreach (var r in ClassforObjects.Reports)
            {
                string line =
                    $"{r.Time} | {r.GameName} | {r.Result} | Bet: {r.BetAmount} | Balance: {r.BalanceAfter}";
                e.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, 20, y);
                y += 20;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClassforObjects.menu.Show();
            ClassforObjects.rf.Hide();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(0, 67, 129);
            btnClose.ForeColor = SystemColors.Control;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.Control;
            btnClose.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            btnPrint.BackColor = SystemColors.Control;
            btnPrint.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void btnPrint_MouseEnter(object sender, EventArgs e)
        {
            btnPrint.ForeColor = SystemColors.Control;
            btnPrint.BackColor = Color.FromArgb(0, 67, 129);
        }
    }
}
