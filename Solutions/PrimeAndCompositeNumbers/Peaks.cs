using System;
using System.Collections.Generic;

namespace Codility.Solutions.PrimeAndCompositeNumbers
{
    // https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/peaks/
    public class Peaks
    {
        public int Solution(int[] A)
        {
            int maxBlock = 0;
            int N = A.Length;
            List<int> allBlocks = new List<int>();
            List<int> allPeeks = new List<int>();

            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)
                    allBlocks.Add(i);

                if (i > 0 && i < N - 1 && A[i] > A[i - 1] && A[i] > A[i + 1])
                    allPeeks.Add(i);
            }

            for (int i = 0; i < allBlocks.Count; i++)
            {
                int blockSize = N / allBlocks[i];
                bool[] found = new bool[allBlocks[i]];
                int count = 0;
                for (int k = 0; k < allPeeks.Count; k++)
                {
                    int peekInBlock = allPeeks[k] / blockSize;
                    if (!found[peekInBlock])
                    {
                        found[peekInBlock] = true;
                        count++;
                    }
                }

                if (count == allBlocks[i])
                    maxBlock = Math.Max(maxBlock, allBlocks[i]);

            }

            return maxBlock;
        }
    }
}