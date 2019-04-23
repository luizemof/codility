using System;
namespace Codility.Solutions.Leader
{
    // https://app.codility.com/programmers/lessons/8-leader/equi_leader/
    public class EquiLeader
    {
        public int Solution(int[] A)
        {
            int N = A.Length;
            int leaderIndex = LeaderIndex(A);
            int equiLeader = 0;

            if (leaderIndex >= 0)
            {
                int totalLeaderCount = 0;
                for (int i = 0; i < N; i++)
                {
                    if (A[i] == A[leaderIndex])
                        totalLeaderCount++;
                }

                int totalLeft = 0;
                int totalRight = totalLeaderCount;
                for (int i = 0; i < N; i++)
                {
                    if (A[i] == A[leaderIndex])
                    {
                        totalLeft++;
                        totalRight--;
                    }

                    if ((i + 1) / 2 < totalLeft && (N - i - 1) / 2 < totalRight)
                        equiLeader++;
                }

            }
            return equiLeader;
        }

        public int LeaderIndex(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
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