using System;

namespace Codility.Solutions.CountElements
{
    // https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
    public class FrogRiverOne
    {
        public int Solution(int X, int[] A)
        {
            bool[] countElments = new bool[X];
            int count = 0;
            for (int k = 0; k < A.Length; k++)
            {
                if(A[k] <= X && !countElments[A[k] - 1])
                {
                    countElments[A[k] - 1] = true;
                    count++;
                }

                if(count == X)
                {
                    return k;
                }
            }

            return -1;
        }
    }
}