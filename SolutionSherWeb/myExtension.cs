using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SolutionSherWeb
{
    static class myExtension
    {
        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k)
        {
            var myList = k == 0 ? new[] { new T[0] } : elements.SelectMany((e, i) =>
                  elements.Skip(i + 1).Combinations(k - 1).Select(c => (new[] { e }).Concat(c)));
            return myList;
        }
    }
}


