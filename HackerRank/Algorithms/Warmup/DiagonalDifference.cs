using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    public class DiagonalDifference
    {
        static int diagonalDifference(int[][] a)
        {
            int diagonal = 0;
            int subDiagonal = 0;

            int temp = a.Length -1;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (i == j)
                        diagonal += a[i][j];

                    if (j == temp)
                        subDiagonal += a[i][j];
                }
                temp--;
            }

            return Math.Abs(diagonal - subDiagonal);
        }

        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int result = diagonalDifference(a);
            Console.WriteLine(result);
        }

        public List<string> Main(List<string> args)
        {
            var result = new List<string>();

            int n = Convert.ToInt32(args[0]);

            int[][] a = new int[n][];

            for (int a_i = 1; a_i <= n; a_i++)
            {
                string[] a_temp = args[a_i].Split(' ');
                a[a_i -1] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int difference = diagonalDifference(a);

            result.Add(difference.ToString());

            return result;
        }
    }
}