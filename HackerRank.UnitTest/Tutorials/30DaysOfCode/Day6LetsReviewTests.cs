using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Tutorials._30DaysOfCode
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class Day6LetsReviewTests
    {
        [TestMethod]
        public void Day6LetsReviewTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var results = new HackerRank.Tutorials._30DaysOfCode.Day6LetsReview().Main(inputs);

            Utils.CompareOutputs(results, methodName);
        }
    }
}