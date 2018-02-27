using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day5Loops
    {

        public List<string> Main(List<string> args)
        {
            int n = Convert.ToInt32(args[0]);

            var result = new List<string>();

            for (int i = 1; i < 11; i++)
            {
                result.Add($"{n} x {i} = {n * i}");
            }

            return result;
        }

        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
