using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day1DataTypes
    {
        /// <summary>
        /// Here is the solution for the website. It says: read from stdin, NOT from args
        /// </summary>
        /// <param name="args"></param>
        public void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int secondInt = Convert.ToInt32(Console.ReadLine());
            double secondDouble = Convert.ToDouble(Console.ReadLine());
            string secondString = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine((i + secondInt).ToString());

            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + secondDouble).ToString("##.0"));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine($"{s}{secondString}");

        }

        /// <summary>
        /// Solution to test locally. Might be able to read from args.
        /// </summary>
        /// <param name="args">Inputs from the TXT file</param>
        /// <returns></returns>
        public List<string> Main(List<string> args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int secondInt = Convert.ToInt32(args[0]);
            double secondDouble = Convert.ToDouble(args[1]);
            string secondString = args[2];

            var result = new List<string>();

            // Print the sum of both integer variables on a new line.
            result.Add((i + secondInt).ToString());

            // Print the sum of the double variables on a new line.
            result.Add((d + secondDouble).ToString("##.0"));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            result.Add($"{s}{secondString}");

            return result;
        }
    }
}