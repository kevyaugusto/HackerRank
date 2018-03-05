using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Tutorials._30DaysOfCode
{
    [TestClass]
    public class Day9RecursionTests
    {
        [TestMethod]
        public void Day9RecursionTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;
            
            var inputs = Utils.ReadInput(methodName);

            var results = new HackerRank.Tutorials._30DaysOfCode.Day9Recursion().Main(inputs);

            Utils.CompareOutputs(results, methodName);
        }
    }
}
