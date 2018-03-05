using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day9Recursion
    {
        public List<string> Main(List<string> args)
        {
            var n = int.Parse(args[0]);

            var output = Factorial(n);

            return new List<string>() { output.ToString() };
        }

        private int Factorial(int n)
        {
            if (n == 1)
                return n;

            return n * Factorial(n - 1);
        }
    }
}
