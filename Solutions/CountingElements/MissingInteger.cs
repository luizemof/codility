using System;
using System.Collections.Generic;

namespace Codility.Solutions.CountElements
{
    // https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
    internal class MissingInteger
    {
        public int Solution(int[] A)
        {
            int[] countingElements = new int[1000000];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    countingElements[A[i] - 1]++;
                }
            }

            for (int i = 0; i < countingElements.Length; i++)
            {
                if (countingElements[i] == 0)
                    return i + 1;
            }

            return 1;
        }
    }
}