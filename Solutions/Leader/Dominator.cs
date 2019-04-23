using System;
namespace Codility.Solutions.Leader
{
    // https://app.codility.com/programmers/lessons/8-leader/dominator/
    public class Dominator
    {
        public int Solution(int[] A)
        {
            int index = 0;
            int tempValue = -1;
            int size = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (size == 0)
                {
                    size++;
                    tempValue = A[i];
                    index = i;
                }
                else
                {
                    if (tempValue == A[i])
                    {
                        size++;
                    }
                    else
                    {
                        size--;
                    }
                }
            }

            if (size > 0)
            {
                int checkCount = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == tempValue)
                        checkCount++;

                    if (checkCount > A.Length / 2)
                        break;
                }

                return checkCount > A.Length / 2 ? index : -1;
            }

            return -1;
        }
    }
}