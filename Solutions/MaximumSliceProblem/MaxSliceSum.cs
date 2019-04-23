using System;
namespace Codility.Solutions.MaximumSliceProblem
{
    // https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_slice_sum/
    public class MaxSliceSum
    {
        public int Solution(int[] A)
        {
            int max = -10000000;
            int maxEnd = -10000000;

            foreach (var a in A)
            {
                maxEnd =  Math.Max(a, maxEnd + a);
                max = Math.Max(max, maxEnd);
            }

            return max;
        }
    }
}