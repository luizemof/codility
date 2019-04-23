using System;
using System.Linq;
using System.Collections.Generic;
namespace Codility.Solutions.Sorting
{
    // https://app.codility.com/programmers/lessons/6-sorting/distinct/
    public class Distinct
    {
        public int Solution(int[] A)
        {
            IEnumerable<int> result = A.Distinct();
            return result.Count();
        }
    }
}