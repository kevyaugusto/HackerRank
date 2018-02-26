using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Algorithms.Warmup
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class BirthdayCakeCandlesTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void BirthdayCakeCandlesTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var result = new HackerRank.Algorithms.Warmup.BirthdayCakeCandles().Main(inputs);

            Utils.CompareOutputs(result, methodName);
        }
    }
}