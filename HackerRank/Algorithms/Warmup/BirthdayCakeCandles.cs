using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    public class BirthdayCakeCandles
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            var query = (from v in ar
                         orderby v descending
                         select v);

            var tallestHeight = query.First();

            var result = query.Count(f => f == tallestHeight);

            return result;
        }

        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }

        public List<string> Main(List<string> inputs)
        {
            int n = Convert.ToInt32(inputs[0]);

            string[] ar_temp = inputs[1].Split(' ');

            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);

            int result = birthdayCakeCandles(n, ar);
            
            var resultFormatted = new List<string>();

            resultFormatted.Add(result.ToString());

            return resultFormatted;
        }
    }
}