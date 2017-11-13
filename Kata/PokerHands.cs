using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class PokerHands
    {
     

        public string WhoWin(string[] black , string[] white)
        {
            //示意判斷相等，這裡沒有考慮 array 怎麼判斷相等的問題
            if(black == white)
            {
                return "Tie."
            }
            
            return "White wins. - with highcard: Ace"; 

        }
    }
}
