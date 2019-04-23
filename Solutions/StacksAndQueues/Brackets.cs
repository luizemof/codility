using System;
using System.Collections.Generic;
using System.Linq;
namespace Codility.Solutions.StacksAndQueues
{
    // https://app.codility.com/programmers/lessons/7-stacks_and_queues/brackets/
    public class Brackets
    {
        public int Solution(string S)
        {
            Stack<char> stack = new Stack<char>();
            char[] openArray = new char[] { '(', '[', '{' };
            if (!string.IsNullOrWhiteSpace(S))
            {
                foreach (var c in S)
                {
                    if (openArray.Contains(c))
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        char expectedOpen = ' ';
                        switch (c)
                        {
                            case '}':
                                expectedOpen = '{';
                                break;
                            case ']':
                                expectedOpen = '[';
                                break;
                            case ')':
                                expectedOpen = '(';
                                break;

                        }

                        if (stack.Count == 0 || expectedOpen != stack.Pop())
                        {
                            return 0;
                        }
                    }
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}