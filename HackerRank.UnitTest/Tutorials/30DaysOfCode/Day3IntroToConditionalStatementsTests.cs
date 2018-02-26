using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Tutorials._30DaysOfCode
{
    [TestClass]
    public class Day3IntroToConditionalStatementsTests
    {
        [TestMethod]
        public void Day3IntroToConditionalStatementsTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var result = new HackerRank.Tutorials._30DaysOfCode.Day3IntroToConditionalStatements().Main(inputs);

            Utils.CompareOutputs(result, methodName);
        }

        [TestMethod]
        public void Day3IntroToConditionalStatementsTest01()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var result = new HackerRank.Tutorials._30DaysOfCode.Day3IntroToConditionalStatements().Main(inputs);

            Utils.CompareOutputs(result, methodName);
        }
    }
}
