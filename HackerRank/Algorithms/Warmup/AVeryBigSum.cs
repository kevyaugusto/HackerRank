﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    public class AVeryBigSum
    {
        static long aVeryBigSum(int n, long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = aVeryBigSum(n, ar);
            Console.WriteLine(result);            
        }
    }
}