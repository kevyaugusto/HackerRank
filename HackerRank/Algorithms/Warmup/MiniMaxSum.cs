using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    public class MiniMaxSum
    {
        static void miniMaxSum(int[] arr)
        {
            var sumTotal = new System.Collections.Generic.List<long>();

            for (int i = 0; i < arr.Length; i++)
            {
                long sum = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;

                    sum += arr[j];
                }

                sumTotal.Add(sum);
            }

            var query = (from value in sumTotal
                         orderby value ascending
                         select value);

            var min = query.First();
            var max = query.Last();

            Console.Write("{0} {1}", min, max);
        }

        static List<string> miniMaxSumResult(int[] arr)
        {
            var sumTotal = new System.Collections.Generic.List<long>();

            for (int i = 0; i < arr.Length; i++)
            {
                long sum = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;

                    sum += arr[j];
                }

                sumTotal.Add(sum);
            }

            var query = (from value in sumTotal
                         orderby value ascending
                         select value);


            var result = new List<string>();

            result.Add(query.First().ToString() + " " + query.Last().ToString());

            return result;
        }

        public void Main(string[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');

            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            miniMaxSum(arr);
        }

        public List<string> Main(List<string> inputs)
        {
            var result = new List<string>();

            string[] arr_temp = inputs[0].Split(' ');

            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            result = miniMaxSumResult(arr);

            return result;
        }
    }
}