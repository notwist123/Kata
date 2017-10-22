using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class TennisScoring
    {
        public string getScoringResult(int player1Win, int player2Win)
        {
            List<string> scoringList = new List<string> { "Love", "Fifteen", "Thirty", "Forty" };

            if ((player1Win == player2Win) && (player1Win >= 3)) return "Deuce.";
            if (player1Win > 3 || player2Win > 3)
            {
                if (Math.Abs(player1Win - player2Win) >= 2)
                    return player1Win > player2Win? "Player1 Win.": "Player2 Win.";
                if (Math.Abs(player1Win - player2Win) == 1)
                    return player1Win > player2Win ? "Player1 Advantage." : "Player2 Advantage.";
            }

            return scoringList[player1Win] + " - " + scoringList[player2Win];
        }
    }
}
