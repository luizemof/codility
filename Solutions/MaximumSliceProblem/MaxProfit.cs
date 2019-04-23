using System;
namespace Codility.Solutions.MaximumSliceProblem
{

    // https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_profit/
    public class MaxProfit
    {
        public int Solution(int[] A)
        {
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int profit = 0;

            foreach (var a in A)
            {
                if (minValue > a)
                {
                    maxValue = int.MinValue;
                    minValue = a;
                }
                else
                {
                    maxValue = Math.Max(maxValue, a);
                    profit = Math.Max(profit, maxValue - minValue);
                }
            }

            return profit;
        }
    }
}