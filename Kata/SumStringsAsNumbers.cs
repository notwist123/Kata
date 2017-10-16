using System;
using System.Collections.Generic;

namespace Kata
{
    public class SumStringsAsNumbers
    {
        private List<char> numberList;
        private string numberA;
        private string numberB;
        private int carryNum;
        public string sumStrings(string a, string b)
        {
            numberList = new List<char>();
            carryNum = 0;
            numberA = a;
            numberB = b;

            sumNumber(numberA.Length - 1, numberB.Length - 1);
            numberList.Insert(0, carryNum.ToString()[0]);

            return new string(numberList.ToArray()).TrimStart('0');
        }

        private void sumNumber(int i, int j)
        {
            if (i > -1 || j > -1)
            {
                int an = 0, bn = 0;
                if (i >= 0) Int32.TryParse(numberA[i].ToString(), out an);
                if (j >= 0) Int32.TryParse(numberB[j].ToString(), out bn);

                string newNum = (an + bn + carryNum).ToString();

                numberList.Insert(0, newNum[newNum.Length - 1]);
                carryNum = newNum.Length > 1 ? 1 : 0;
                sumNumber(i - 1, j - 1);
            }
        }
    }
}
