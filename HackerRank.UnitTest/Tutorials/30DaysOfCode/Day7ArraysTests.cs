using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Tutorials._30DaysOfCode
{
    [TestClass]
    public class Day7ArraysTests
    {
        [TestMethod]
        public void Day7ArraysTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var result = new HackerRank.Tutorials._30DaysOfCode.Day7Arrays().Main(inputs);

            Utils.CompareOutputs(result, methodName);

        }
    }
}
