using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class BandNameGenerator
    {
        public string NameGenerator(string name)
        {
            char[] charCollect = name.ToCharArray();

            charCollect[0] = Char.ToUpper(charCollect[0]);
            if (charCollect[0] == Char.ToUpper(charCollect[charCollect.Length - 1]))
            {
                charCollect = charCollect.Concat(charCollect.Skip(1)).ToArray();
                return new string(charCollect);
            }

            return "The " + new string(charCollect);
        }
    }
}
