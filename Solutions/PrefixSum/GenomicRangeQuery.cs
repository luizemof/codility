using System;
namespace Codility.Solutions.PrefixSum
{
    // https://app.codility.com/programmers/lessons/5-prefix_sums/genomic_range_query/
    public class GenomicRangeQuery
    {
        public int[] Solution(string S, int[] P, int[] Q)
        {
            int M = P.Length;
            int N = S.Length;
            int[] result = new int[M];

            int[] A = new int[N];
            int[] C = new int[N];
            int[] G = new int[N];
            int[] T = new int[N];

            switch (S[0])
            {
                case 'A':
                    A[0] = 1;
                    break;
                case 'C':
                    C[0] = 1;
                    break;
                case 'G':
                    G[0] = 1;
                    break;
                case 'T':
                    T[0] = 1;
                    break;
            }

            for (int i = 1; i < S.Length; i++)
            {
                A[i] = GetValue(S[i], 'A', A, i - 1);
                C[i] = GetValue(S[i], 'C', C, i - 1);
                G[i] = GetValue(S[i], 'G', G, i - 1);
                T[i] = GetValue(S[i], 'T', T, i - 1);
            }

            for (int i = 0; i < M; i++)
            {
                int pIndex = P[i];
                int qIndex = Q[i];
                int factor;
                if (A[pIndex] != A[qIndex] || S[pIndex] == 'A')
                {
                    factor = 1;
                }
                else if (C[pIndex] != C[qIndex] || S[pIndex] == 'C')
                {
                    factor = 2;
                }
                else if (G[pIndex] != G[qIndex] || S[pIndex] == 'G')
                {
                    factor = 3;
                }
                else
                {
                    factor = 4;
                }

                result[i] = factor;
            }

            return result;
        }

        private int GetValue(char source, char targetValue, int[] array, int i)
        {
            return source == targetValue ? array[i] + 1 : array[i];
        }
    }
}