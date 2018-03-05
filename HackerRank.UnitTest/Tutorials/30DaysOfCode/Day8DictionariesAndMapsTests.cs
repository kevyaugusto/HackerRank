using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest.Tutorials._30DaysOfCode
{
    [TestClass]
    public class Day8DictionariesAndMapsTests
    {
        [TestMethod]
        public void Day8DictionariesAndMapsTest00()
        {
            var methodName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            var inputs = Utils.ReadInput(methodName);

            List<string> result = new HackerRank.Tutorials._30DaysOfCode.Day8DictionariesAndMaps().Main(inputs);

            Utils.CompareOutputs(result, methodName);
        }
    }
}
