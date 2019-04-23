using System;
namespace Codility.Solutions.Sorting
{
    // https://app.codility.com/programmers/lessons/6-sorting/triangle/
    public class Triangle
    {
        public int Solution(int[] A)
        {
            int N = A.Length;
            Array.Sort(A);
            for (int i = 0; i < N - 2; i++)
            {
                if(((long)A[i] + (long)A[i + 1]) > A[i + 2])
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}