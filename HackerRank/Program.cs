using HackerRank.Algorithms.Warmup;
using HackerRank.Tutorials._30DaysOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //new SolveMeFirst().Main(args);
            //new AVeryBigSum().Main(args);
            //new PlusMinus().Main(args);
            new Day10Binary().Main(new List<string>());

            var cultureInfo = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            var formats = cultureInfo.DateTimeFormat.GetAllDateTimePatterns();

            var a = System.Globalization.DateTimeFormatInfo.GetInstance(null);
            

            foreach (var f in formats)
            {
                Console.WriteLine(f);
            }



            //var r = DateTime.Parse("07:05:45PM");
            //var r = DateTime.Parse("12:00:00PM");
            var r = DateTime.Parse("12:00:00AM");

            Console.WriteLine(r);
            Console.WriteLine(r.TimeOfDay);
            Console.WriteLine(r.ToString("HH:mm:ss"));
            Console.WriteLine(r.ToString("hh:mm:ss"));
            Console.WriteLine(r.ToString("H:mm:ss"));
            Console.WriteLine(r.ToString("h:mm:ss"));

            Console.ReadLine();
        }
    }
}
