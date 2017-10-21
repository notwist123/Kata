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
            List<string> scoringList = new List<string> {"Love","Fifteen","Thirty","Forty"};
            string player1Result;
            string player2Result;

            if ((player1Win == player2Win) && (player1Win >= 3)) return "Deuce.";
            if (player1Win > 3 || player2Win > 3)
            {
                if (player1Win - player2Win >= 2) return "Player1 Win.";
                if (player2Win - player1Win >= 2) return "Player2 Win.";
                if (player1Win - player2Win == 1) return "Player1 Advantage.";
                if (player2Win - player1Win == 1) return "Player2 Advantage.";
            }
            player1Result = scoringList[player1Win];
            player2Result = scoringList[player2Win];

            return player1Result + " - " + player2Result;
        }
    }
}
