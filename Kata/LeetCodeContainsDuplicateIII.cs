using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class LeetCodeContainsDuplicateIII
    {
        public bool ContainsNearbyAlmostDuplicate(int[] inputArray, int absoluteDiffIndex, int absoluteDiffNumber)
        {
            if (absoluteDiffNumber != 0)
            {
                var duplicateIndex = inputArray.Select((x, i) => new { x, i }).OrderBy(l => l.x).ToArray();
                var duplicateIndexCopy = duplicateIndex;

                for (int i = 0; i < duplicateIndex.Length; i++)
                {
                    var maxNumber = duplicateIndexCopy[0].x + absoluteDiffNumber;
                    var groupArr = duplicateIndexCopy.TakeWhile(x => x.x <= maxNumber).Select(s => s.i).ToArray();
                    if (IsAbsoluteDiff(absoluteDiffIndex, groupArr)) return true;
                    duplicateIndexCopy = duplicateIndexCopy.Skip(1).ToArray();
                }
                return false;
            }

            var duplicateIndex2 = inputArray.Select((x, i) => new { x, i }).GroupBy(g => g.x).Where(w => w.Count() > 1);

            foreach (var g in duplicateIndex2)
            {
                var groupArr = g.Select(x => x.i).ToArray();
                if (IsAbsoluteDiff(absoluteDiffIndex, groupArr)) return true;
            }
            return false;
        }

        private static bool IsAbsoluteDiff(int absoluteDiffIndex, int[] groupArr)
        {
            for (var i = 0; i < groupArr.Length - 1; i++)
            {
                for (var j = i + 1; j < groupArr.Length; j++)
                {
                    if (Math.Abs(groupArr[i] - groupArr[j]) <= absoluteDiffIndex) return true;
                }
            }
            return false;
        }
    }
}
