using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    public class PlusMinus
    {
        private static void plusMinus(int[] arr)
        {
            decimal totalPositive = 0, totalNegative = 0, totalZeroes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    totalZeroes++;
                else if (arr[i] > 0)
                    totalPositive++;
                else
                    totalNegative++;
            }

            decimal fractionPositive = totalPositive / arr.Length;
            decimal fractionNegative = totalNegative / arr.Length;
            decimal fractionZeroes = totalZeroes / arr.Length;

            Console.WriteLine(fractionPositive.ToString());
            Console.WriteLine(fractionNegative.ToString());
            Console.WriteLine(fractionZeroes.ToString());
        }

        private static List<string> plusMinusResult(int[] arr)
        {
            decimal totalPositive = 0, totalNegative = 0, totalZeroes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    totalZeroes++;
                else if (arr[i] > 0)
                    totalPositive++;
                else
                    totalNegative++;
            }

            decimal fractionPositive = totalPositive / arr.Length;
            decimal fractionNegative = totalNegative / arr.Length;
            decimal fractionZeroes = totalZeroes / arr.Length;

            var result = new List<string>();
            result.Add(fractionPositive.ToString());
            result.Add(fractionNegative.ToString());
            result.Add(fractionZeroes.ToString());

            return result;
        }

        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            plusMinus(arr);
        }

        public List<string> Main(List<string> args)
        {
            var result = new List<string>();

            int n = Convert.ToInt32(args[0]);

            string[] arr_temp = args[1].Split(' ');

            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            result = plusMinusResult(arr);

            return result;
        }
    }
}
