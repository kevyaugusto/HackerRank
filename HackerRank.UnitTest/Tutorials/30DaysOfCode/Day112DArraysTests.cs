using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Tutorials._30DaysOfCode
{
    [TestClass]
    public class Day112DArraysTests
    {
        [TestMethod]
        public void Day112DArraysTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var results = new HackerRank.Tutorials._30DaysOfCode.Day11_2DArrays().Main(inputs);

            Utils.CompareOutputs(results, methodName);
        }

        [TestMethod]
        public void Day112DArraysTest01()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var results = new HackerRank.Tutorials._30DaysOfCode.Day11_2DArrays().Main(inputs);

            Utils.CompareOutputs(results, methodName);
        }
    }
}
