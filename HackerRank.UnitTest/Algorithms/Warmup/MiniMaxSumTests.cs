using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace HackerRank.UnitTest.Algorithms.Warmup
{
    [TestClass]
    public class MiniMaxSumTests
    {
        [TestMethod]
        public void MiniMaxSumTest00()
        {
            var methodName = MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var result = new HackerRank.Algorithms.Warmup.MiniMaxSum().Main(inputs);            

            Utils.CompareOutputs(result, methodName);
        }
    }
}
