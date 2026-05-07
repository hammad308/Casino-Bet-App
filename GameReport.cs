using System;
using System.Collections.Generic;
using System.Text;

namespace Casino_Bet_App
{
    public class GameReport
    {
        public DateTime Time { get; set; }
        public string GameName { get; set; }   
        public string Result { get; set; }     
        public int BetAmount { get; set; }
        public int BalanceAfter { get; set; }
    }
}
