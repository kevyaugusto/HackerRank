using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Tutorials._30DaysOfCode
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class Day5LoopsTests
    {
        [TestMethod]
        public void Day5LoopsTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var results = new HackerRank.Tutorials._30DaysOfCode.Day5Loops().Main(inputs);

            Utils.CompareOutputs(results, methodName);
        }
    }
}