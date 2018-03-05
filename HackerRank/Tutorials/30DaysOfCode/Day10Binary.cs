using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day10Binary
    {
        public List<string> Main(List<string> args)
        {
            int base10Integer = int.Parse(args[0]);

            var integerInBytes = System.BitConverter.GetBytes(base10Integer);

            var bitArr = new BitArray(integerInBytes);

            int consecutiveOnes = 0, maxConsecutiveOnes = 0;

            for (int i = 0; i < bitArr.Length; i++)
            {
                var v = bitArr.Get(i);

                consecutiveOnes = v
                    ? consecutiveOnes + 1
                    : 0;                

                if (consecutiveOnes > maxConsecutiveOnes)
                    maxConsecutiveOnes = consecutiveOnes;
            }

            return new List<string>() { maxConsecutiveOnes.ToString() };
        }

        public void Main(string[] args)
        {
            int base10Integer = int.Parse(Console.ReadLine());

            var integerInBytes = System.BitConverter.GetBytes(base10Integer);

            var bitArr = new BitArray(integerInBytes);

            int consecutiveOnes = 0, maxConsecutiveOnes = 0;

            for (int i = 0; i < bitArr.Length; i++)
            {
                var v = bitArr.Get(i);

                consecutiveOnes = v
                    ? consecutiveOnes + 1
                    : 0;

                if (consecutiveOnes > maxConsecutiveOnes)
                    maxConsecutiveOnes = consecutiveOnes;
            }

            Console.WriteLine(maxConsecutiveOnes);
        }
    }
}
