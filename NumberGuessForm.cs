using Casino_Bet_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Casino_Bet_And_Win
{
    public partial class NumberGuessForm : Form
    {
        public NumberGuessForm()
        {
            InitializeComponent();
        }

        private void NumberGuesstextBox_Click(object sender, EventArgs e)
        {
            if (NumberGuesstextBox.Text == "Enter Your Guess")
            {
                NumberGuesstextBox.Text = null;
            }
        }

        int rand;

        private void GuessSubmitButton_Click(object sender, EventArgs e)
        {
            int currentBet = ClassforObjects.betAmount;
            if (NumberGuesstextBox.Text != "1" && NumberGuesstextBox.Text != "2" && NumberGuesstextBox.Text != "3" ) { 
                MessageBox.Show("Please Input the number between 1 and 3", "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NumberGuesstextBox.Clear();
            }
            else if (ClassforObjects.betAmount == 0)
            {
                MessageBox.Show("Sorry! You didn't Select the Bet amount", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rand = ClassforObjects.random.Next(1, 4);
                if (rand.ToString() == NumberGuesstextBox.Text)
                {
                    NumberGuesstextBox.Clear();
                    MessageBox.Show("Congratulations! You have guessed the correct number.👏👏👏🙌🙌. " + ClassforObjects.betAmount + " Rs has been added to your balance", "Congratulation❤❤😍😍");
                    ClassforObjects.balance += ClassforObjects.betAmount;
                    ClassforObjects.betAmount = 0;
                    ShowBalnceLabelOnNumberguess.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.menu.ShowBalnceLabelOnMainMenu.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.rollDice.ShowBalnceLabelOnRollDice.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.Reports.Add(new GameReport
                    {
                        Time = DateTime.Now,
                        GameName = "Number Guess",
                        Result = "Win",
                        BetAmount = currentBet,
                        BalanceAfter = ClassforObjects.balance
                    });
                }
                else
                {
                    NumberGuesstextBox.Clear();
                    MessageBox.Show("Sorry! You haven't guessed it correct 👏👏👏🙌🙌. " + "The Actual Number was " + rand + ". " + ClassforObjects.betAmount + " Rs has been deducted from your balance", "Sorry😓😓😓");
                    
                    ClassforObjects.balance -= ClassforObjects.betAmount;
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
                    ShowBalnceLabelOnNumberguess.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.menu.ShowBalnceLabelOnMainMenu.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.rollDice.ShowBalnceLabelOnRollDice.Text = ClassforObjects.balance.ToString();
                    ClassforObjects.Reports.Add(new GameReport
                    {
                        Time = DateTime.Now,
                        GameName = "Number Guess",
                        Result = "Loss",
                        BetAmount = currentBet,
                        BalanceAfter = ClassforObjects.balance
                    });

                }
            }
        }

        private void Thousand_choice_button_Click(object sender, EventArgs e)
        {
            ClassforObjects.betAmount = 1000;
            MessageBox.Show("1000 bet is selected 👏👏👏🙌🙌", "BET AMOUNT");
        }

        private void Twothousand_choice_button_Click(object sender, EventArgs e)
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

        private void Fivethousand_choice_button_Click(object sender, EventArgs e)
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

        private void BackbuttonOnNumberguess_Click(object sender, EventArgs e)
        {
            ClassforObjects.numberGuess.Hide();
            ClassforObjects.menu.Show();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
        }

        private void resetColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void GuessSubmitButton_MouseEnter(object sender, EventArgs e)
        {
            GuessSubmitButton.BackColor = Color.FromArgb(0, 67, 129);
            GuessSubmitButton.ForeColor = SystemColors.Control;
        }

        private void Thousand_choice_button_Numberguess_MouseEnter(object sender, EventArgs e)
        {
            Thousand_choice_button_Numberguess.BackColor = Color.FromArgb(0, 67, 129);
            Thousand_choice_button_Numberguess.ForeColor = SystemColors.Control;
        }

        private void Fivethousand_choice_button_Numberguess_MouseEnter(object sender, EventArgs e)
        {
            Fivethousand_choice_button_Numberguess.BackColor = Color.FromArgb(0, 67, 129);
            Fivethousand_choice_button_Numberguess.ForeColor = SystemColors.Control;
        }

        private void Twothousand_choice_button_Numberguess_MouseEnter(object sender, EventArgs e)
        {
            Twothousand_choice_button_Numberguess.BackColor = Color.FromArgb(0, 67, 129);
            Twothousand_choice_button_Numberguess.ForeColor = SystemColors.Control;
        }

        private void Thousand_choice_button_Numberguess_MouseLeave(object sender, EventArgs e)
        {
            Thousand_choice_button_Numberguess.BackColor = SystemColors.Control;
            Thousand_choice_button_Numberguess.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void Twothousand_choice_button_Numberguess_MouseLeave(object sender, EventArgs e)
        {
            Twothousand_choice_button_Numberguess.BackColor = SystemColors.Control;
            Twothousand_choice_button_Numberguess.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void Fivethousand_choice_button_Numberguess_MouseLeave(object sender, EventArgs e)
        {
            Fivethousand_choice_button_Numberguess.BackColor = SystemColors.Control;
            Fivethousand_choice_button_Numberguess.ForeColor = Color.FromArgb(0, 67, 129);
        }

        private void GuessSubmitButton_MouseLeave(object sender, EventArgs e)
        {
            GuessSubmitButton.BackColor = SystemColors.Control;
            GuessSubmitButton.ForeColor = Color.FromArgb(0, 67, 129);
        }
    }
}



