using System;
using System.Collections.Generic;
using System.Linq;
namespace Codility.Solutions.StacksAndQueues
{
    public class Nesting
    {
        // https://app.codility.com/programmers/lessons/7-stacks_and_queues/nesting
        public int Solution(string S)
        {
            Stack<char> stack = new Stack<char>();
            int N = S.Length;
            if (!string.IsNullOrEmpty(S))
            {
                foreach (var c in S)
                {
                    if(c == '(')
                    {
                        stack.Push(c);
                    }
                    else if(stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            return Convert.ToInt32(stack.Count == 0);
        }
    }
}