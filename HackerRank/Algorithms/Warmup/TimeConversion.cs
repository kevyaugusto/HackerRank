using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    public class TimeConversion
    {
        static string timeConversion(string s)
        {
            string result = DateTime.Parse(s, new System.Globalization.CultureInfo("en-US")).TimeOfDay.ToString();           

            return result;
        }

        public void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }

        public List<string> Main(List<string> inputs)
        {
            string s = inputs[0];

            string result = timeConversion(s);          

            return new List<string>() { result };
        }
    }
}
