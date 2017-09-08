using System;
using System.Linq;

namespace Kata
{
    public class StringAverage
    {
        static void Main(string[] args)
        {
        }
        private string[] stringsOfNumbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private String[] _numbers;
        private int sum;

        public string AverageString(string str)
        {
            _numbers = str.Split(' ');
            sum = 0;
            foreach (string s in _numbers)
            {
                if (isNotRegular(s)) return "n/a";
                sum = sum + stringTransToNumber(s);
            }

            return stringsOfNumbers[sum / _numbers.Length];
        }

        private int stringTransToNumber(string str)
        {
            int i;
            for (i = 0; i < stringsOfNumbers.Length; i++)
            {
                if (str == stringsOfNumbers[i]) break;
            }
            return i;
        }

        private bool isNotRegular(string str)
        {
            return (str == "") || (!stringsOfNumbers.Contains(str));
        }
    }
}
