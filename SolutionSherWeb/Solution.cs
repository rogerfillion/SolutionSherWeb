using System;
using System.Collections.Generic;
using System.Linq;

namespace SolutionSherWeb
{
    public class Solution
    {
        public int mySolution(int[] A, int K)
        {
            var myList = A.Combinations(K).ToList()
                .Select(i => i.ToList()).ToList()
                .Where(x => (x.Sum() + 2) % 2 == 0);
            
            if (myList.Count() == 0) return -1;

            var result=myList
                    .Max(x=> x.Sum());
            return result;
        }
    }
}
