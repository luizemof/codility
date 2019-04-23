using System;
namespace Codility.Solutions.Sorting
{
    // https://app.codility.com/programmers/lessons/6-sorting/max_product_of_three/
    public class MaxProductOfThree
    {
        public int Solution(int[] A)
        {
            Array.Sort(A);
            int N = A.Length;
            int P1 = A[0] * A[1];
            int P2 = A[N - 3] * A[N - 2];
            return A[N - 1] * (P1 > P2 ? P1 : P2);
        }
    }
}
