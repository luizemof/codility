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

            for (int flags = 2; flags < allPeeks.Count; flags++)
            {
                int count = flags - 1;
                int lastFlagIndex = 0;
                for (int j = 1; j < allPeeks.Count && count > 0; j++)
                {
                    int diff = Math.Abs(allPeeks[lastFlagIndex] - allPeeks[j]);
                    if (diff >= flags)
                    {
                        lastFlagIndex = j;
                        count--;
                    }
                }

                if(count == 0)
                {
                    maxFlags = Math.Max(maxFlags, flags);
                }
            }

            return maxFlags;
        }
    }
}