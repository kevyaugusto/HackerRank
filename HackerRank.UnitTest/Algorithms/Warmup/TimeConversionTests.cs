using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Algorithms.Warmup
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class TimeConversionTests
    {
        [TestMethod]
        public void TimeConversionTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var result = new HackerRank.Algorithms.Warmup.TimeConversion().Main(inputs);

            Utils.CompareOutputs(result, methodName);
        }
    }
}
