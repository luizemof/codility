using System;

namespace Codility.Solutions.TimeComplexity
{
    // https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
    public class PermMissingElem
    {
        public int Solution(int[] A)
        {
            int minimal;
            int totalSum = 0;
            for (int i = 1; i < A.Length; i++)
                totalSum -= A[i];

            totalSum = A[0] + totalSum;
            minimal = Math.Abs(totalSum);
            for (int i = 1; i < A.Length - 1; i++)
            {
                totalSum = (2*A[i]) + totalSum;
                if (Math.Abs(totalSum) < minimal)
                    minimal = Math.Abs(totalSum);

                if (minimal == 0)
                    break;
            }

            return minimal == int.MaxValue ? 0 : minimal;
        }
    }
}