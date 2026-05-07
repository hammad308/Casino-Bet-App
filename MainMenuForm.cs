using Casino_Bet_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Casino_Bet_And_Win
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void NumberGuessButton_Click(object sender, EventArgs e)
        {
            ClassforObjects.menu.Hide();
            ClassforObjects.numberGuess.Show();
        }
        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LuckyDiceButton_Click(object sender, EventArgs e)
        {
            ClassforObjects.menu.Hide();
            ClassforObjects.rollDice.Show();
        }

        private void NumberGuessButton_MouseEnter(object sender, EventArgs e)
        {
            NumberGuessButton.BackColor = Color.FromArgb(0, 67, 129);
            NumberGuessButton.ForeColor = SystemColors.Control;
        }

        private void NumberGuessButton_MouseLeave(object sender, EventArgs e)
        {
            NumberGuessButton.BackColor = SystemColors.Control;
            NumberGuessButton.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void LuckyDiceButton_MouseLeave(object sender, EventArgs e)
        {
            LuckyDiceButton.BackColor = SystemColors.Control;
            LuckyDiceButton.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void LuckyDiceButton_MouseEnter(object sender, EventArgs e)
        {
            LuckyDiceButton.BackColor = Color.FromArgb(0, 67, 129);
            LuckyDiceButton.ForeColor = SystemColors.Control;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            ClassforObjects.rf.Show();
            ClassforObjects.menu.Hide();
        }

        private void btnShowReport_MouseEnter(object sender, EventArgs e)
        {
            btnShowReport.BackColor = Color.FromArgb(0, 67, 129);
            btnShowReport.ForeColor = SystemColors.Control;
        }

        private void btnShowReport_MouseLeave(object sender, EventArgs e)
        {
            btnShowReport.BackColor = SystemColors.Control;
            btnShowReport.ForeColor = Color.FromArgb(0, 67, 129);
        }
    }
}
