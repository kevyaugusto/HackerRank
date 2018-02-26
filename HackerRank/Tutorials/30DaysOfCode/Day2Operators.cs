using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day2Operators
    {

        public void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            double tipCost = meal_cost * (tip_percent / 100D);
            double taxCost = meal_cost * (tax_percent / 100D);
            var totalCost = Math.Round(meal_cost + tipCost + taxCost);

            Console.WriteLine($"The total meal cost is {totalCost} dollars.");
        }

        public List<string> Main(List<string> args)
        {
            double meal_cost = Convert.ToDouble(args[0]);
            int tip_percent = Convert.ToInt32(args[1]);
            int tax_percent = Convert.ToInt32(args[2]);

            double tipCost = meal_cost * (tip_percent / 100D);
            double taxCost = meal_cost * (tax_percent / 100D);
            var totalCost = Math.Round(meal_cost + tipCost + taxCost);

            return new List<string>()
            {
                $"The total meal cost is {totalCost} dollars."
            };
        }
    }
}