using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solutions.SOTI.Test
{
    public class SOTIDemoTask
    {
        public int Solution(int[] A)
        {
            var orededValues = A.OrderBy(x => x);
            int diff;
            int result = 1;
            bool found = false;
            int i = 0;
            for (; i < orededValues.Count() - 1; i++)
            {
                diff = orededValues.ElementAt(i + 1) - orededValues.ElementAt(i);
                if (orededValues.ElementAt(i) > 0 && diff > 1)
                {
                    found = true;
                    result = orededValues.ElementAt(i) + 1;
                    break;
                }
            }

            if(!found && orededValues.ElementAt(i) > 0)
            {
                result = orededValues.ElementAt(i) + 1;
            }

            return result;
        }
    }
}
