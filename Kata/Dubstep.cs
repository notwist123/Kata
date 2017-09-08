using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Dubstep
    {
        public string SongDecoder(string input)
        {
            input = trimStartAndEnd(input);
            input = replaceSpace(input);
            return input;
        }

        private string replaceSpace(string input)
        {
            if (input.Contains("WUB")) input = replaceSpace(input.Replace("WUB", " "));
            if (input.Contains("  ")) input = replaceSpace(input.Replace("  ", " "));
            return input;
        }

        private string trimStartAndEnd(string input)
        {
            if (input.StartsWith("WUB")) input = trimStartAndEnd(input.Substring(3));
            if (input.EndsWith("WUB")) input = trimStartAndEnd(input.Substring(0, input.Length - 3));

            return input;
        }
    }
}
