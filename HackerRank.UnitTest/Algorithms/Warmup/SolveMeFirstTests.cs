using HackerRank.Algorithms.Warmup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Algorithms.Warmup
{
    [TestClass]
    public class SolveMeFirstTests
    {
        [TestMethod]
        public void SolveMeFirstTest00()
        {
            var methodName = MethodInfo.GetCurrentMethod().Name;

            var input = Utils.ReadInput(methodName);

            var result = new SolveMeFirst().Main(input);

            Utils.CompareOutputs(result, methodName);
        }
    }
}
