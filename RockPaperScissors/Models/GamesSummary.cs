using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Models
{
    public class GamesSummary
    {
        public int TotalGamesPlayed { get; set; }
        public int PlayerOneWinTotal { get; set; }
        public int PlayerTwoWinTotal { get; set; }
        public int DrawTotal { get; set; }

        public GamesSummary()
        {
            TotalGamesPlayed = 0;
            PlayerOneWinTotal = 0;
            PlayerTwoWinTotal = 0;
            DrawTotal = 0;
        }
    }
}
