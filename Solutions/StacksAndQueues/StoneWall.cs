using System;
using System.Collections.Generic;
namespace Codility.Solutions.StacksAndQueues
{
    // https://app.codility.com/programmers/lessons/7-stacks_and_queues/stone_wall
    public class StoneWall
    {
        public int Solution(int[] H)
        {
            Stack<int> stones = new Stack<int>();
            int totalStones = 0;
            foreach (var height in H)
            {
                while (stones.Count > 0 && stones.Peek() > height)
                    stones.Pop();

                if (stones.Count != 0 && stones.Peek() == height)
                    continue;
                else
                {
                    totalStones++;
                    stones.Push(height);
                }
            }


            return totalStones;
        }
    }
}