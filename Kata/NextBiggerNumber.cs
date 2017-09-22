using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class NextBiggerNumber
    {
        private List<long> numberList = new List<long>(); 
        public long NextBigger(long n)
        {
            findNumbers("",n.ToString());
            numberList.Sort();

            return checkNumber(n.ToString())? numberList[numberList.FindIndex(x => x ==n) + 1] : -1;
        } 

        private void findNumbers(string combine, string number)
        {
            if (number.Length == 0 && !numberList.Contains(Convert.ToInt64(combine))) 
                numberList.Add(Convert.ToInt64(combine));              
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    findNumbers(combine + number[i], number.Substring(0,i) + number.Substring(i+1));
                }
            }
        }

        private bool checkNumber(string number)
        {
            if (number.Length == 1) return false;
            if (number.GroupBy(x => x).Count() == 1) return false;
            if (Convert.ToInt64(number) == numberList.Max()) return false;
            return true;
        }
    }
}
