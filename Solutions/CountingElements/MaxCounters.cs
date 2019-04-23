using System;
namespace Codility.Solutions.CountElements
{
    // https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/
    internal class MaxCounters
    {
        public int[] Solution(int N, int[] A)
        {
            int[] counters = new int[N];
            int maxCount = 0;
            int tempMaxCountValue = 0;
            for (int k = 0; k < A.Length; k++)
            {
                if (A[k] <= N)
                {
                    if(counters[A[k] - 1] < maxCount)
                    {
                        counters[A[k] - 1] = maxCount;
                    }

                    counters[A[k] - 1]++;
                    if (tempMaxCountValue < counters[A[k] - 1])
                    {
                        tempMaxCountValue = counters[A[k] - 1];
                    }
                }
                else
                {
                    maxCount = tempMaxCountValue;
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                if(counters[i] < maxCount)
                {
                    counters[i] = maxCount;
                }
            }

            return counters;
        }
        
        // public int[] Solution(int N, int[] A)
        // {
        //     int[] counters = new int[N];
        //     int maxCount = 0;
        //     for (int k = 0; k < A.Length; k++)
        //     {
        //         if (A[k] <= N)
        //         {
        //             counters[A[k] - 1]++;
        //             if (maxCount < counters[A[k] - 1])
        //             {
        //                 maxCount = counters[A[k] - 1];
        //             }
        //         }
        //         else
        //         {
        //             for (int i = 0; i < counters.Length; i++)
        //             {
        //                 counters[i] = maxCount;
        //             }
        //         }
        //     }

        //     return counters;
        // }
    }
}