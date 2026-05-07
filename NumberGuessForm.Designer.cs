namespace Casino_Bet_And_Win
{
    partial class NumberGuessForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberGuessForm));
            NumberGuesstextBox = new TextBox();
            GuessSubmitButton = new Button();
            Thousand_choice_button_Numberguess = new Button();
            Fivethousand_choice_button_Numberguess = new Button();
            Twothousand_choice_button_Numberguess = new Button();
            BackbuttonOnNumberguess = new Button();
            ShowBalnceLabelOnNumberguess = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            changeColorToolStripMenuItem = new ToolStripMenuItem();
            resetColorToolStripMenuItem = new ToolStripMenuItem();
            RulesLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // NumberGuesstextBox
            // 
            NumberGuesstextBox.BackColor = SystemColors.Control;
            NumberGuesstextBox.BorderStyle = BorderStyle.FixedSingle;
            NumberGuesstextBox.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumberGuesstextBox.ForeColor = Color.FromArgb(0, 67, 129);
            NumberGuesstextBox.Location = new Point(283, 400);
            NumberGuesstextBox.Margin = new Padding(4, 5, 4, 5);
            NumberGuesstextBox.Multiline = true;
            NumberGuesstextBox.Name = "NumberGuesstextBox";
            NumberGuesstextBox.Size = new Size(325, 52);
            NumberGuesstextBox.TabIndex = 0;
            NumberGuesstextBox.Text = "Enter Your Guess";
            NumberGuesstextBox.TextAlign = HorizontalAlignment.Center;
            NumberGuesstextBox.Click += NumberGuesstextBox_Click;
            // 
            // GuessSubmitButton
            // 
            GuessSubmitButton.BackColor = SystemColors.Control;
            GuessSubmitButton.FlatAppearance.BorderSize = 0;
            GuessSubmitButton.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuessSubmitButton.ForeColor = Color.FromArgb(0, 67, 129);
            GuessSubmitButton.Location = new Point(266, 680);
            GuessSubmitButton.Margin = new Padding(4, 5, 4, 5);
            GuessSubmitButton.Name = "GuessSubmitButton";
            GuessSubmitButton.Size = new Size(358, 85);
            GuessSubmitButton.TabIndex = 4;
            GuessSubmitButton.Text = "Submit Guess";
            GuessSubmitButton.UseVisualStyleBackColor = false;
            GuessSubmitButton.Click += GuessSubmitButton_Click;
            GuessSubmitButton.MouseEnter += GuessSubmitButton_MouseEnter;
            GuessSubmitButton.MouseLeave += GuessSubmitButton_MouseLeave;
            // 
            // Thousand_choice_button_Numberguess
            // 
            Thousand_choice_button_Numberguess.BackColor = SystemColors.Control;
            Thousand_choice_button_Numberguess.FlatAppearance.BorderSize = 0;
            Thousand_choice_button_Numberguess.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thousand_choice_button_Numberguess.ForeColor = Color.FromArgb(0, 67, 129);
            Thousand_choice_button_Numberguess.Location = new Point(116, 539);
            Thousand_choice_button_Numberguess.Margin = new Padding(4, 5, 4, 5);
            Thousand_choice_button_Numberguess.Name = "Thousand_choice_button_Numberguess";
            Thousand_choice_button_Numberguess.Size = new Size(193, 68);
            Thousand_choice_button_Numberguess.TabIndex = 5;
            Thousand_choice_button_Numberguess.Text = "1000Rs";
            Thousand_choice_button_Numberguess.UseVisualStyleBackColor = false;
            Thousand_choice_button_Numberguess.Click += Thousand_choice_button_Click;
            Thousand_choice_button_Numberguess.MouseEnter += Thousand_choice_button_Numberguess_MouseEnter;
            Thousand_choice_button_Numberguess.MouseLeave += Thousand_choice_button_Numberguess_MouseLeave;
            // 
            // Fivethousand_choice_button_Numberguess
            // 
            Fivethousand_choice_button_Numberguess.BackColor = SystemColors.Control;
            Fivethousand_choice_button_Numberguess.FlatAppearance.BorderSize = 0;
            Fivethousand_choice_button_Numberguess.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fivethousand_choice_button_Numberguess.ForeColor = Color.FromArgb(0, 67, 129);
            Fivethousand_choice_button_Numberguess.Location = new Point(588, 539);
            Fivethousand_choice_button_Numberguess.Margin = new Padding(4, 5, 4, 5);
            Fivethousand_choice_button_Numberguess.Name = "Fivethousand_choice_button_Numberguess";
            Fivethousand_choice_button_Numberguess.Size = new Size(184, 68);
            Fivethousand_choice_button_Numberguess.TabIndex = 6;
            Fivethousand_choice_button_Numberguess.Text = "5000Rs";
            Fivethousand_choice_button_Numberguess.UseVisualStyleBackColor = false;
            Fivethousand_choice_button_Numberguess.Click += Fivethousand_choice_button_Click;
            Fivethousand_choice_button_Numberguess.MouseEnter += Fivethousand_choice_button_Numberguess_MouseEnter;
            Fivethousand_choice_button_Numberguess.MouseLeave += Fivethousand_choice_button_Numberguess_MouseLeave;
            // 
            // Twothousand_choice_button_Numberguess
            // 
            Twothousand_choice_button_Numberguess.BackColor = SystemColors.Control;
            Twothousand_choice_button_Numberguess.FlatAppearance.BorderSize = 0;
            Twothousand_choice_button_Numberguess.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Twothousand_choice_button_Numberguess.ForeColor = Color.FromArgb(0, 67, 129);
            Twothousand_choice_button_Numberguess.Location = new Point(346, 539);
            Twothousand_choice_button_Numberguess.Margin = new Padding(4, 5, 4, 5);
            Twothousand_choice_button_Numberguess.Name = "Twothousand_choice_button_Numberguess";
            Twothousand_choice_button_Numberguess.Size = new Size(206, 68);
            Twothousand_choice_button_Numberguess.TabIndex = 7;
            Twothousand_choice_button_Numberguess.Text = "2000Rs";
            Twothousand_choice_button_Numberguess.UseVisualStyleBackColor = false;
            Twothousand_choice_button_Numberguess.Click += Twothousand_choice_button_Click;
            Twothousand_choice_button_Numberguess.MouseEnter += Twothousand_choice_button_Numberguess_MouseEnter;
            Twothousand_choice_button_Numberguess.MouseLeave += Twothousand_choice_button_Numberguess_MouseLeave;
            // 
            // BackbuttonOnNumberguess
            // 
            BackbuttonOnNumberguess.BackColor = SystemColors.Control;
            BackbuttonOnNumberguess.BackgroundImage = (Image)resources.GetObject("BackbuttonOnNumberguess.BackgroundImage");
            BackbuttonOnNumberguess.BackgroundImageLayout = ImageLayout.Stretch;
            BackbuttonOnNumberguess.FlatAppearance.BorderSize = 0;
            BackbuttonOnNumberguess.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BackbuttonOnNumberguess.ForeColor = Color.White;
            BackbuttonOnNumberguess.ImageAlign = ContentAlignment.MiddleLeft;
            BackbuttonOnNumberguess.Location = new Point(4, 3);
            BackbuttonOnNumberguess.Margin = new Padding(4, 5, 4, 5);
            BackbuttonOnNumberguess.Name = "BackbuttonOnNumberguess";
            BackbuttonOnNumberguess.Size = new Size(86, 82);
            BackbuttonOnNumberguess.TabIndex = 8;
            BackbuttonOnNumberguess.TextAlign = ContentAlignment.MiddleRight;
            BackbuttonOnNumberguess.UseVisualStyleBackColor = false;
            BackbuttonOnNumberguess.Click += BackbuttonOnNumberguess_Click;
            // 
            // ShowBalnceLabelOnNumberguess
            // 
            ShowBalnceLabelOnNumberguess.BackColor = SystemColors.Control;
            ShowBalnceLabelOnNumberguess.BorderStyle = BorderStyle.FixedSingle;
            ShowBalnceLabelOnNumberguess.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowBalnceLabelOnNumberguess.ForeColor = Color.FromArgb(0, 67, 129);
            ShowBalnceLabelOnNumberguess.Location = new Point(696, 4);
            ShowBalnceLabelOnNumberguess.Margin = new Padding(4, 0, 4, 0);
            ShowBalnceLabelOnNumberguess.Name = "ShowBalnceLabelOnNumberguess";
            ShowBalnceLabelOnNumberguess.Padding = new Padding(7, 8, 7, 8);
            ShowBalnceLabelOnNumberguess.Size = new Size(186, 82);
            ShowBalnceLabelOnNumberguess.TabIndex = 9;
            ShowBalnceLabelOnNumberguess.Text = "10000";
            ShowBalnceLabelOnNumberguess.TextAlign = ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.WhiteSmoke;
            contextMenuStrip1.Font = new Font("Segoe UI", 10F);
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { changeColorToolStripMenuItem, resetColorToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(179, 72);
            // 
            // changeColorToolStripMenuItem
            // 
            changeColorToolStripMenuItem.Image = (Image)resources.GetObject("changeColorToolStripMenuItem.Image");
            changeColorToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            changeColorToolStripMenuItem.Size = new Size(178, 34);
            changeColorToolStripMenuItem.Text = "Change Color";
            changeColorToolStripMenuItem.Click += changeColorToolStripMenuItem_Click;
            // 
            // resetColorToolStripMenuItem
            // 
            resetColorToolStripMenuItem.Name = "resetColorToolStripMenuItem";
            resetColorToolStripMenuItem.Size = new Size(178, 34);
            resetColorToolStripMenuItem.Text = "Reset Color";
            resetColorToolStripMenuItem.Click += resetColorToolStripMenuItem_Click;
            // 
            // RulesLabel
            // 
            RulesLabel.BackColor = SystemColors.Control;
            RulesLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic);
            RulesLabel.ForeColor = Color.FromArgb(0, 67, 129);
            RulesLabel.ImageAlign = ContentAlignment.TopLeft;
            RulesLabel.Location = new Point(126, 461);
            RulesLabel.Margin = new Padding(4, 0, 4, 0);
            RulesLabel.Name = "RulesLabel";
            RulesLabel.Padding = new Padding(7, 8, 7, 8);
            RulesLabel.Size = new Size(638, 59);
            RulesLabel.TabIndex = 15;
            RulesLabel.Text = "Rule: Guess The Correct Number between 1 and 3";
            RulesLabel.TextAlign = ContentAlignment.MiddleCenter;
            RulesLabel.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Showcard Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 67, 129);
            label1.Location = new Point(126, 285);
            label1.Name = "label1";
            label1.Size = new Size(606, 78);
            label1.TabIndex = 16;
            label1.Text = "NUMBER GUESS GAME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(0, 67, 129);
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(116, 612);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(7, 8, 7, 8);
            label2.Size = new Size(638, 63);
            label2.TabIndex = 17;
            label2.Text = "Press on Any Button to Enter the Amount of Bet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(330, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(705, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // NumberGuessForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 786);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RulesLabel);
            Controls.Add(ShowBalnceLabelOnNumberguess);
            Controls.Add(BackbuttonOnNumberguess);
            Controls.Add(Twothousand_choice_button_Numberguess);
            Controls.Add(Fivethousand_choice_button_Numberguess);
            Controls.Add(Thousand_choice_button_Numberguess);
            Controls.Add(GuessSubmitButton);
            Controls.Add(NumberGuesstextBox);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "NumberGuessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NumberGuessForm";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumberGuesstextBox;
        private Button GuessSubmitButton;
        private Button Fivethousand_choice_button_Numberguess;
        private Button Twothousand_choice_button_Numberguess;
        private Button BackbuttonOnNumberguess;
        public Button Thousand_choice_button_Numberguess;
        public Label ShowBalnceLabelOnNumberguess;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem changeColorToolStripMenuItem;
        private ToolStripMenuItem resetColorToolStripMenuItem;
        public Label RulesLabel;
        private Label label1;
        public Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}