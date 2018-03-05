using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day7Arrays
    {
        public List<string> Main(List<string> args)
        {
            var result = new List<string>();

            var n = int.Parse(args[0]);

            var a = args[1].Split(' ').ToList();
            a.Reverse();

            var output = string.Empty;

            a.ForEach(item => output += $"{item} ");

            result.Add(output.Trim());

            return result;
        }

        public void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var a = Console.ReadLine().Split(' ').ToList();

            a.Reverse();

            var output = string.Empty;

            a.ForEach(item => output += $"{item} ");

            Console.WriteLine(output.Trim());
        }
    }
}