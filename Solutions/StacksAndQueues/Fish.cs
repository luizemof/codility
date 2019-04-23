using System;
using System.Collections.Generic;
namespace Codility.Solutions.StacksAndQueues
{
    // https://app.codility.com/programmers/lessons/7-stacks_and_queues/fish/start/
    public class Fish
    {
        public int Solution(int[] A, int[] B)
        {
            int N = A.Length;
            Stack<Tuple<int, bool>> fishes = new Stack<Tuple<int, bool>>();
            Tuple<int, bool> top = Tuple.Create(A[0], B[0] == 0);
            fishes.Push(top);
            for (int i = 1; i < N; i++)
            {
                if ( top == null || top.Item2 || B[i] == 1)
                {
                    fishes.Push(Tuple.Create(A[i], B[i] == 0));
                }
                else
                {
                    if (top.Item1 < A[i])
                    {
                        fishes.Pop();
                        i--;
                    }
                }

                top = fishes.Count > 0 ? fishes.Peek() : null;
            }

            return fishes.Count;
        }
    }
}