using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Tutorials._30DaysOfCode
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class Day1DataTypeTests
    {
        [TestMethod]
        public void Day1DataTypeTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            var result = new HackerRank.Tutorials._30DaysOfCode.Day1DataTypes().Main(inputs);

            Utils.CompareOutputs(result, methodName);
        }
    }
}
