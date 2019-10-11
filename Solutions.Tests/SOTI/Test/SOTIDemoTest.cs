using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.SOTI.Test;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Tests.SOTI.Test
{
    [TestClass]
    public class SOTIDemoTest
    {
        [TestMethod]
        public void Basic()
        {
            int[] a = new int[] { 1, 2, 3 };
            new SOTIDemoTask().Solution(a);
        }
    }
}
