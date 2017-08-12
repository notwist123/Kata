using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class DeadAnts
    {
        private int count = 0;
        public int DeadAntCount(string ants)
        {
            if (ants == null) return count;

            ants = ants.Replace("ant","");
            return Math.Max(ants.Count(c => c == 'a'), Math.Max(ants.Count(c => c == 'n'),ants.Count(c => c == 't')));
        }
    }
}
