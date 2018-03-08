using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day11_2DArrays
    {
        public List<string> Main(List<string> args)
        {
            var matrixRows = int.Parse(args[0].Split(' ')[0]);
            var matrixColumns = int.Parse(args[0].Split(' ')[1]);

            int[,] arr = new int[matrixRows, matrixColumns];

            for (int arr_i = 0; arr_i < matrixRows; arr_i++)
            {
                string[] arr_temp = args[arr_i+1].Split(' ');

                for (int arr_j = 0; arr_j < matrixColumns; arr_j++)
                {
                    arr[arr_i, arr_j] = int.Parse(arr_temp[arr_j]);
                }                
            }

            //Hour glass representation in a matrix
            //a b c   -> row 1
            //  d     -> row 2
            //e f g   -> row 3

            var maxHourGlassSum = int.MinValue;
            var rowLimit = matrixRows - 2;
            var columnLimit = matrixColumns - 2;

            for (int row = 0; row < rowLimit; row++)
            {
                for (int column = 0; column < columnLimit; column++)
                {
                    var hourglassSum = arr[row, column] + arr[row, column + 1] + arr[row, column + 2] //row 1
                        + arr[row + 1, column + 1] //row 2
                        + arr[row + 2, column] + arr[row + 2, column + 1] + arr[row + 2, column + 2]; //row 3

                    maxHourGlassSum = System.Math.Max(maxHourGlassSum, hourglassSum);
                }
            }

            return new List<string>() { maxHourGlassSum.ToString() };
        }

        public void Main(string[] args)
        {

        }
    }
}