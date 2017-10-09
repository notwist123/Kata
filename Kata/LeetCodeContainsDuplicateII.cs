using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class LeetCodeContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] inputArray, int absoluteDiff)
        {
            var duplicateIndex = inputArray.Select((x, i) => new {x, i}).GroupBy(g => g.x).Where(w => w.Count() > 1);

            foreach (var g in duplicateIndex)
            {
                var groupArr = g.Select(x => x.i).ToArray();
                for (var i = 0; i < groupArr.Length-1; i++)
                {
                    for (var j = i + 1; j < groupArr.Length; j++)
                    {
                        if (groupArr[j] - groupArr[i] <= absoluteDiff) return true;
                    }
                }
            }
            return false;
        }
    }
}
