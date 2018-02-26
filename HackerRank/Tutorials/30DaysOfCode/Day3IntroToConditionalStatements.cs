using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day3IntroToConditionalStatements
    {
        public List<string> Main(List<string> args)
        {
            int N = Convert.ToInt32(args[0]);

            var rest = N % 2;

            var result = new List<string>();

            if (rest == 1)
            {
                result.Add("Weird");
            }
            else
            {
                if (N >= 2 && N <= 5)
                    result.Add("Not Weird");
                else if (N >= 6 && N <= 20)
                    result.Add("Weird");
                else if (N >= 20)
                    result.Add("Not Weird");
            }

            return result;
        }

        public void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            var rest = N % 2;

            var result = new List<string>();

            if (rest == 1)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (N >= 2 && N <= 5)
                    Console.WriteLine("Not Weird");
                else if (N >= 6 && N <= 20)
                    Console.WriteLine("Weird");
                else if (N >= 20)
                    Console.WriteLine("Not Weird");
            }
        }
    }
}
