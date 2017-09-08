using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class CountingDuplicates
    {
        public int DuplicateCount(string str)
        {
            if (!str.Equals(""))
            {
                return str.ToLower().Substring(1).Contains(str.ToLower().Substring(0, 1))
                    ? 1 + DuplicateCount(str.ToLower().Replace(str.ToLower().Substring(0, 1), ""))
                    : DuplicateCount(str.ToLower().Replace(str.ToLower().Substring(0, 1), ""));
            }
            return 0;
        }
    }
}
