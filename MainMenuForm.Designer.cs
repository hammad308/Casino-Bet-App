namespace Casino_Bet_And_Win
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            NumberGuessButton = new Button();
            LuckyDiceButton = new Button();
            ExitGameButton = new Button();
            Balancetextlabel = new Label();
            ShowBalnceLabelOnMainMenu = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnShowReport = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NumberGuessButton
            // 
            NumberGuessButton.BackColor = SystemColors.Control;
            NumberGuessButton.BackgroundImageLayout = ImageLayout.None;
            NumberGuessButton.CausesValidation = false;
            NumberGuessButton.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            NumberGuessButton.FlatAppearance.BorderSize = 0;
            NumberGuessButton.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumberGuessButton.ForeColor = Color.FromArgb(0, 67, 129);
            NumberGuessButton.ImageAlign = ContentAlignment.TopCenter;
            NumberGuessButton.Location = new Point(153, 649);
            NumberGuessButton.Margin = new Padding(4, 5, 4, 5);
            NumberGuessButton.Name = "NumberGuessButton";
            NumberGuessButton.Size = new Size(187, 99);
            NumberGuessButton.TabIndex = 0;
            NumberGuessButton.Text = "Number Guess";
            NumberGuessButton.UseVisualStyleBackColor = false;
            NumberGuessButton.Click += NumberGuessButton_Click;
            NumberGuessButton.MouseEnter += NumberGuessButton_MouseEnter;
            NumberGuessButton.MouseLeave += NumberGuessButton_MouseLeave;
            // 
            // LuckyDiceButton
            // 
            LuckyDiceButton.BackColor = SystemColors.Control;
            LuckyDiceButton.CausesValidation = false;
            LuckyDiceButton.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            LuckyDiceButton.FlatAppearance.BorderSize = 0;
            LuckyDiceButton.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LuckyDiceButton.ForeColor = Color.FromArgb(0, 67, 129);
            LuckyDiceButton.Location = new Point(382, 649);
            LuckyDiceButton.Margin = new Padding(4, 5, 4, 5);
            LuckyDiceButton.Name = "LuckyDiceButton";
            LuckyDiceButton.Size = new Size(177, 99);
            LuckyDiceButton.TabIndex = 1;
            LuckyDiceButton.Text = "Lucky Dice";
            LuckyDiceButton.UseVisualStyleBackColor = false;
            LuckyDiceButton.Click += LuckyDiceButton_Click;
            LuckyDiceButton.MouseEnter += LuckyDiceButton_MouseEnter;
            LuckyDiceButton.MouseLeave += LuckyDiceButton_MouseLeave;
            // 
            // ExitGameButton
            // 
            ExitGameButton.BackColor = SystemColors.Control;
            ExitGameButton.BackgroundImage = (Image)resources.GetObject("ExitGameButton.BackgroundImage");
            ExitGameButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExitGameButton.CausesValidation = false;
            ExitGameButton.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            ExitGameButton.FlatAppearance.BorderSize = 0;
            ExitGameButton.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitGameButton.ForeColor = Color.DarkBlue;
            ExitGameButton.Location = new Point(597, 649);
            ExitGameButton.Margin = new Padding(4, 5, 4, 5);
            ExitGameButton.Name = "ExitGameButton";
            ExitGameButton.Size = new Size(129, 99);
            ExitGameButton.TabIndex = 2;
            ExitGameButton.UseVisualStyleBackColor = false;
            ExitGameButton.Click += ExitGameButton_Click;
            // 
            // Balancetextlabel
            // 
            Balancetextlabel.BackColor = SystemColors.Control;
            Balancetextlabel.BorderStyle = BorderStyle.FixedSingle;
            Balancetextlabel.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balancetextlabel.ForeColor = Color.FromArgb(0, 67, 129);
            Balancetextlabel.Location = new Point(1, 2);
            Balancetextlabel.Margin = new Padding(4, 0, 4, 0);
            Balancetextlabel.Name = "Balancetextlabel";
            Balancetextlabel.Padding = new Padding(7, 8, 7, 8);
            Balancetextlabel.Size = new Size(232, 63);
            Balancetextlabel.TabIndex = 3;
            Balancetextlabel.Text = "Balance(Rs):";
            // 
            // ShowBalnceLabelOnMainMenu
            // 
            ShowBalnceLabelOnMainMenu.BackColor = SystemColors.Control;
            ShowBalnceLabelOnMainMenu.BorderStyle = BorderStyle.FixedSingle;
            ShowBalnceLabelOnMainMenu.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowBalnceLabelOnMainMenu.ForeColor = Color.FromArgb(0, 67, 129);
            ShowBalnceLabelOnMainMenu.Location = new Point(229, 2);
            ShowBalnceLabelOnMainMenu.Margin = new Padding(4, 0, 4, 0);
            ShowBalnceLabelOnMainMenu.Name = "ShowBalnceLabelOnMainMenu";
            ShowBalnceLabelOnMainMenu.Padding = new Padding(7, 8, 7, 8);
            ShowBalnceLabelOnMainMenu.Size = new Size(133, 63);
            ShowBalnceLabelOnMainMenu.TabIndex = 4;
            ShowBalnceLabelOnMainMenu.Text = "10000";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Showcard Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 67, 129);
            label1.Location = new Point(224, 537);
            label1.Name = "label1";
            label1.Size = new Size(438, 113);
            label1.TabIndex = 13;
            label1.Text = "BET AND WIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(213, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnShowReport
            // 
            btnShowReport.BackColor = SystemColors.Control;
            btnShowReport.CausesValidation = false;
            btnShowReport.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            btnShowReport.FlatAppearance.BorderSize = 0;
            btnShowReport.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowReport.ForeColor = Color.FromArgb(0, 67, 129);
            btnShowReport.Location = new Point(626, 5);
            btnShowReport.Margin = new Padding(4, 5, 4, 5);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(256, 60);
            btnShowReport.TabIndex = 15;
            btnShowReport.Text = "Show Record";
            btnShowReport.UseVisualStyleBackColor = false;
            btnShowReport.Click += btnShowReport_Click;
            btnShowReport.MouseEnter += btnShowReport_MouseEnter;
            btnShowReport.MouseLeave += btnShowReport_MouseLeave;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 786);
            Controls.Add(btnShowReport);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ShowBalnceLabelOnMainMenu);
            Controls.Add(Balancetextlabel);
            Controls.Add(ExitGameButton);
            Controls.Add(LuckyDiceButton);
            Controls.Add(NumberGuessButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button LuckyDiceButton;
        private Button ExitGameButton;
        public Button NumberGuessButton;
        private Label Balancetextlabel;
        public Label ShowBalnceLabelOnMainMenu;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnShowReport;
    }
}