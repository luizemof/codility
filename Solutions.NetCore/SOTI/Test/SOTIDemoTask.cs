using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solutions.NetCore.SOTI.Test
{
    public class SOTIDemoTask
    {
        public int Task1(int[] A)
        {
            int maxRange = 1000000;
            int[] countElements = new int[maxRange];
            int result = 1;
            foreach (var currentValue in A)
            {
                if(currentValue > 0)
                {
                    countElements[currentValue - 1]++;
                }
            }

            for (int i = 0; i < maxRange; i++)
            {
                if(countElements[i] == 0)
                {
                    result  = i + 1;
                    break;
                }
            }

            return result;
        }
    }
}
