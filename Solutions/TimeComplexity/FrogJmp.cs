using System;

namespace Codility.Solutions.TimeComplexity
{
    // https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
    public class FrogJmp
    {
        public int Solution(int[] A)
        {
            int N = A.Length;
            int count = 0;
            int arrayCount = 0;
            for (int i = 1; i <= N; i++)
            {
                count += i;
                arrayCount += A[i - 1];
            }

            int diff = arrayCount - count;
            return (N + 1) - (diff < 0 ? diff * (-1) : diff);
        }
    }
}