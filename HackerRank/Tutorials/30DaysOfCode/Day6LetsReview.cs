using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day6LetsReview
    {
        public List<string> Main(List<string> args)
        {
            var result = new List<string>();

            var n = int.Parse(args[0]);

            for (int i = 0; i < n; i++)
            {
                var s = args[i + 1];

                string even = string.Empty, odd = string.Empty;

                for (int j = 0; j < s.Length; j++)
                {
                    var c = s[j];

                    if (j % 2 == 0)
                        even += c;
                    else
                        odd += c;
                }

                result.Add($"{even} {odd}");
            }

            return result;
        }

        public void Main(string[] args)
        {
            var result = new List<string>();

            var n = int.Parse(args[0]);

            for (int i = 0; i < n; i++)
            {
                var s = args[i + 1];

                string even = string.Empty, odd = string.Empty;

                for (int j = 0; j < s.Length; j++)
                {
                    var c = s[j];

                    if (j % 2 == 0)
                        even += c;
                    else
                        odd += c;
                }

                result.Add($"{even} {odd}");
            }

            return result;
        }
    }
}