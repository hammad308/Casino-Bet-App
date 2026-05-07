using Casino_Bet_App;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casino_Bet_And_Win
{
    public static class ClassforObjects
    {
        public static MainMenuForm menu = new MainMenuForm();
        public static SplashForm splash = new SplashForm();
        public static NumberGuessForm numberGuess = new NumberGuessForm();
        public static int balance = 10000;
        public static RollDiceForm rollDice=new RollDiceForm();
        public static Random random = new Random();
        public static int betAmount;
        public static List<GameReport> Reports = new List<GameReport>();
        public static ReportForm rf=new ReportForm();
    }
}
