using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class NextBiggerNumberWithSameDigits
    {
        private static List<char> numberList;

        public long NextBiggerNumber(long n)
        {
            numberList = n.ToString().ToCharArray().ToList();

            if (!checkNumber(numberList)) return -1;
            return findNumbers();
        }

        private long findNumbers()
        {
            Tuple<int,int> swapTuple = findTuple();

            var temp = numberList[swapTuple.Item1];
            numberList[swapTuple.Item1] = numberList[swapTuple.Item2];
            numberList[swapTuple.Item2] = temp;

            numberList = numberList.Take(swapTuple.Item1 + 1).Concat(numberList.Skip(swapTuple.Item1 + 1).OrderBy(o => o))
                        .ToList();

            return Convert.ToInt64(new string(numberList.ToArray()));
        }

        private Tuple<int, int> findTuple()
        {
            int item1 = 0, item2 = 0;
            int lastNum=0;
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= item1; j--)
                {
                    if (numberList[j] == numberList[i]) break;

                    if (numberList[j] < numberList[i])
                    {
                        if (numberList[j] > lastNum || (item1 == 0 && item2 == 0))
                        {
                            item1 = j;
                            item2 = i;
                        }
                    }
                }
                lastNum = Convert.ToInt32(numberList[i]);
            }
            return new Tuple<int, int>(item1,item2);
        }
        
        private bool checkNumber(List<char> number)
        {
            if (number.Count == 1) return false;
            if (number.GroupBy(x => x).Count() == 1) return false;
            if (number.SequenceEqual(number.OrderByDescending(o => o).ToArray())) return false;

            return true;
        }
    }
}
