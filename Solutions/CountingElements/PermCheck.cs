using System;

namespace Codility.Solutions.CountElements
{
    // https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
    internal class PermCheck
    {
        public int Solution(int[] A)
        {
            int N = A.Length;
            int[] countElements = new int[N];
            for (int i = 0; i < N; i++)
            {
                if (A[i] <= N)
                {
                    countElements[A[i] - 1]++;
                }
                else
                {
                    return 0;
                }
            }

            foreach (var count in countElements)
            {
                if (count != 1)
                    return 0;
            }

            return 1;
        }
    }
}