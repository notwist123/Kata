using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class PokerHands
    {
        private List<string> stringsOfNumbers = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private List<string> stringsOfName = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Quen", "King", "Ace" };
        private int sum;

        public string WhoWin(string[] black , string[] white)
        {
            var blackNumber = black.Select(s => stringsOfNumbers.IndexOf(s.Substring(0, 1))).ToList();
            var whiteNumber = white.Select(s => stringsOfNumbers.IndexOf(s.Substring(0, 1))).ToList();
            var blackSuit = black.Select(s => s.Substring(1, 1)).ToList();
            var whiteSuit = white.Select(s => s.Substring(1, 1)).ToList();

            if (whiteNumber.GroupBy(x => x).Count() == 5 && whiteNumber.GroupBy(x => x).Count() == 5)
            {
                if (whiteNumber.Max() > blackNumber.Max()) return "White wins. - with highcard: " + stringsOfName[whiteNumber.Max()];
                if (whiteNumber.Max() < blackNumber.Max())
                {
                    return "Black wins. - with highcard:" + stringsOfName[whiteNumber.Max()];
                }
                return "Tie.";
            }

            return "Tie.";
        }
    }
}
