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
    public class PlusMinusTests
    {
        [TestMethod]
        public void PlusMinusTest00()
        {
            var methodName = MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var result = new HackerRank.Algorithms.Warmup.PlusMinus().Main(inputs);

            Utils.CompareOutputs(result, methodName);
        }
    }
}