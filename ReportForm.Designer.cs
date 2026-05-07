namespace Casino_Bet_App
{
    partial class ReportForm
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
            dgvReport = new DataGridView();
            btnPrint = new Button();
            btnClose = new Button();
            Balancetextlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = SystemColors.Control;
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(1, 89);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(782, 494);
            dgvReport.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.Control;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.FromArgb(0, 67, 129);
            btnPrint.Location = new Point(114, 636);
            btnPrint.Margin = new Padding(4, 5, 4, 5);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(199, 59);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            btnPrint.MouseEnter += btnPrint_MouseEnter;
            btnPrint.MouseLeave += btnPrint_MouseLeave;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(0, 67, 129);
            btnClose.Location = new Point(471, 636);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(199, 59);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // Balancetextlabel
            // 
            Balancetextlabel.BackColor = SystemColors.Control;
            Balancetextlabel.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balancetextlabel.ForeColor = Color.FromArgb(0, 67, 129);
            Balancetextlabel.Location = new Point(280, 9);
            Balancetextlabel.Margin = new Padding(4, 0, 4, 0);
            Balancetextlabel.Name = "Balancetextlabel";
            Balancetextlabel.Padding = new Padding(7, 8, 7, 8);
            Balancetextlabel.Size = new Size(215, 77);
            Balancetextlabel.TabIndex = 7;
            Balancetextlabel.Text = "Record";
            Balancetextlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 730);
            Controls.Add(Balancetextlabel);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(dgvReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReport;
        private Button btnPrint;
        private Button btnClose;
        private Label Balancetextlabel;
    }
}