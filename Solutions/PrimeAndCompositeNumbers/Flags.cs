using System;
using System.Collections.Generic;

namespace Codility.Solutions.PrimeAndCompositeNumbers
{
    // https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/flags/
    public class Flags
    {
        public int Solution(int[] A)
        {
            int maxFlags = 0;
            List<int> allPeeks = new List<int>();

            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                    allPeeks.Add(i);
            }

            

            return maxFlags;
        }
    }
}