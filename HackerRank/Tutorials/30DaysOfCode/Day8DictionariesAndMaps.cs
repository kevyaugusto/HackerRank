using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day8DictionariesAndMaps
    {
        public List<string> Main(List<string> args)
        {
            var result = new List<string>();

            var n = int.Parse(args[0]);

            var queries = args.Count - n - 1;

            var phoneBook = new Dictionary<string, long>(n);

            for (int i = 1; i <= n; i++)
            {
                var name = args[i].Split(' ').First();
                var phone = long.Parse(args[i].Split(' ').Last());

                phoneBook.Add(name, phone);
            }

            for (int i = queries + 1; i < args.Count; i++)
            {
                var queryName = args[i];

                var output = phoneBook.ContainsKey(queryName)
                    ? $"{queryName}={phoneBook[queryName]}"
                    : "Not found";

                result.Add(output);
            }

            return result;
        }

        public void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var phoneBook = new Dictionary<string, long>(n);

            for (int i = 1; i <= n; i++)
            {
                var str = Console.ReadLine().Split(' ').ToList();
                var name = str.First();
                var phone = long.Parse(str.Last());

                phoneBook.Add(name, phone);
            }

            var queryName = Console.ReadLine();

            while (!string.IsNullOrEmpty(queryName))
            {
                var output = phoneBook.ContainsKey(queryName)
                    ? $"{queryName}={phoneBook[queryName]}"
                    : "Not found";

                Console.WriteLine(output);

                queryName = Console.ReadLine();
            }
        }
    }
}