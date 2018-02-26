using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTest
{
    public static class Utils
    {

        private static List<string> ReadFile(string path)
        {
            string fullPath = System.IO.Path.Combine(Environment.CurrentDirectory, "TestFiles", path);

            var result = new List<string>();

            if (!System.IO.File.Exists(fullPath))
                throw new FileNotFoundException(fullPath + " does not exist");

            // Open the file to read from
            string[] readText = File.ReadAllLines(fullPath);

            foreach (var line in readText)
            {
                result.Add(line);
            }

            return result;
        }

        public static List<string> ReadInput(string testName)
        {
            return ReadFile(testName + "Input.txt");
        }

        private static List<string> ReadOutput(string testName)
        {
            return ReadFile(testName + "Output.txt");
        }

        public static void CompareOutputs(List<string> actualResult, string path)
        {
            var expected = ReadOutput(path);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actualResult[i]);
            }
        }
    }
}
