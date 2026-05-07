using Casino_Bet_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Casino_Bet_And_Win
{
    public partial class RollDiceForm : Form
    {
        public RollDiceForm()
        {
            InitializeComponent();
        }
        int Dice1Final;
        int Dice2Final;
        int rollTime = 0;
        int currentBet = ClassforObjects.betAmount;
        private void RollDiceButton_Click(object sender, EventArgs e)
        {
            if (ClassforObjects.betAmount == 0)
            {
                MessageBox.Show("Sorry! You didn't Select the Bet amount", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rollTime = 0;
                Rolltimer.Start();
            }
        }

        private void Rolltimer_Tick(object sender, EventArgs e)
        {
            rollTime ++;
            int tempDice1 = ClassforObjects.random.Next(1, 7);
            int tempDice2 = ClassforObjects.random.Next(1, 7);

            pictureBoxDice1.Image = GetDiceImage(tempDice1);
            pictureBoxDice2.Image = GetDiceImage(tempDice2);
            if (rollTime >= 15)
            {
                Rolltimer.Stop();
                Dice1Final = ClassforObjects.random.Next(1, 7);
                Dice2Final = ClassforObjects.random.Next(1, 7);

                pictureBoxDice1.Image = GetDiceImage(Dice1Final);
                pictureBoxDice2.Image = GetDiceImage(Dice2Final);
                if (Dice1Final == Dice2Final)
                {

                    MessageBox.Show("Congratulations! You have Won.👏👏👏🙌🙌 " + ClassforObjects.betAmount + " Rs has been added to your balance", "Congratulation❤❤😍😍");
                    ClassforObjects.balance += ClassforObjects.betAmount;
                    currentBet= ClassforObjects.betAmount;
                    ClassforObjects.betAmount = 0;
                    ShowBalnceLabelOnRollDice.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.menu.ShowBalnceLabelOnMainMenu.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.numberGuess.ShowBalnceLabelOnNumberguess.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.Reports.Add(new GameReport
                    {
                        Time = DateTime.Now,
                        GameName = "Roll Dice",
                        Result = "Win",
                        BetAmount = currentBet,
                        BalanceAfter = ClassforObjects.balance
                    });
                }
                else
                {
                    MessageBox.Show("Sorry! You Lost.😥😥 " + ClassforObjects.betAmount + " Rs has been deducted from your balance", "Sorry😓😓😓");
                    ClassforObjects.balance -= ClassforObjects.betAmount;
                    currentBet = ClassforObjects.betAmount;
                    ClassforObjects.betAmount = 0;
                    if (ClassforObjects.balance == 0)
                    {
                        DialogResult result = MessageBox.Show("Your Account Balance is 0. Do You Want to Deposit 5000 Rs?", "Sorry😓😓😓", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            Application.Exit();
                        }
                        else if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("OK. 5000Rs has been added to your balance", "Congrats🤩🤩", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClassforObjects.balance = 5000;
                        }
                    }
                    ShowBalnceLabelOnRollDice.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.menu.ShowBalnceLabelOnMainMenu.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.numberGuess.ShowBalnceLabelOnNumberguess.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.Reports.Add(new GameReport
                    {
                        Time = DateTime.Now,
                        GameName = "Roll Dice",
                        Result = "Loss",
                        BetAmount = currentBet,
                        BalanceAfter = ClassforObjects.balance
                    });
                }
            }
        }

        private void Thousand_choice_button_RollDice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1000 bet is selected 👏👏👏🙌🙌", "BET AMOUNT");
            ClassforObjects.betAmount = 1000;
        }

        private void Twothousand_choice_button_RollDice_Click(object sender, EventArgs e)
        {
            if (ClassforObjects.balance < 2000)
            {
                MessageBox.Show("This Bet Can't be selected. Because Your Account balance is less than this Bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                ClassforObjects.betAmount = 2000;
                MessageBox.Show("2000 bet is selected 👏👏👏🙌🙌", "BET AMOUNT");
            }
        }

        private void Fivethousand_choice_button_RollDice_Click(object sender, EventArgs e)
        {
            if (ClassforObjects.balance < 5000)
            {
                MessageBox.Show("This Bet Can't be selected. Because Your Account balance is less than this Bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                ClassforObjects.betAmount = 5000;
                MessageBox.Show("5000 is selected 👏👏👏🙌🙌", "BET AMOUNT");
            }
        }

        private void BackbuttonOnRollDice_Click(object sender, EventArgs e)
        {
            ClassforObjects.rollDice.Hide();
            ClassforObjects.menu.Show();
        }

        private void Thousand_choice_button_RollDice_MouseEnter(object sender, EventArgs e)
        {
            Thousand_choice_button_RollDice.BackColor = Color.FromArgb(0, 67, 129);
            Thousand_choice_button_RollDice.ForeColor = SystemColors.Control;
        }

        private void Twothousand_choice_button_RollDice_MouseEnter(object sender, EventArgs e)
        {
            Twothousand_choice_button_RollDice.BackColor = Color.FromArgb(0, 67, 129);
            Twothousand_choice_button_RollDice.ForeColor = SystemColors.Control;
        }

        private void Fivethousand_choice_button_RollDice_MouseEnter(object sender, EventArgs e)
        {
            Fivethousand_choice_button_RollDice.BackColor = Color.FromArgb(0, 67, 129);
            Fivethousand_choice_button_RollDice.ForeColor = SystemColors.Control;
        }

        private void Thousand_choice_button_RollDice_MouseLeave(object sender, EventArgs e)
        {
            Thousand_choice_button_RollDice.BackColor = SystemColors.Control;
            Thousand_choice_button_RollDice.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void Twothousand_choice_button_RollDice_MouseLeave(object sender, EventArgs e)
        {
            Twothousand_choice_button_RollDice.BackColor = SystemColors.Control;
            Twothousand_choice_button_RollDice.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void Fivethousand_choice_button_RollDice_MouseLeave(object sender, EventArgs e)
        {
            Fivethousand_choice_button_RollDice.BackColor = SystemColors.Control;
            Fivethousand_choice_button_RollDice.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void RollDiceButton_MouseLeave(object sender, EventArgs e)
        {
            RollDiceButton.BackColor = SystemColors.Control;
            RollDiceButton.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void RollDiceButton_MouseEnter(object sender, EventArgs e)
        {
            RollDiceButton.BackColor = Color.FromArgb(0, 67, 129);
            RollDiceButton.ForeColor = SystemColors.Control;
        }
        private Image GetDiceImage(int number)
        {
            string path = Path.Combine(Application.StartupPath, "Images", $"dice{number}.png");
            return Image.FromFile(path);
        }
    }
}
