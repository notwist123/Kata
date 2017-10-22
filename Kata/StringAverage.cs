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
                if (s == "" || Array.IndexOf(stringsOfNumbers, s) == -1) return "n/a";
                sum = sum + Array.IndexOf(stringsOfNumbers, s);
            }

            return stringsOfNumbers[sum / _numbers.Length];
        }
    }
}
