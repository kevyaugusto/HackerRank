using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class Day4ClassVsInstance
    {

        public List<string> Main(List<string> args)
        {
            int T = int.Parse(args[0]);

            var result = new List<string>();

            for (int i = 1; i <= T; i++)
            {
                int age = int.Parse(args[i]);

                Person p = new Person(age);

                p.amIOld();

                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }

                p.amIOld();

                p.MessageResults.Add(string.Empty);

                result.AddRange(p.MessageResults);
            }

            return result;
        }

        public void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }

    internal class Person
    {
        public Person(int initialAge)
        {
            MessageResults = new List<string>();

            if (initialAge < 0)
            {
                initialAge = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
                MessageResults.Add("Age is not valid, setting age to 0.");
            }
            age = initialAge;
        }

        public int age { get; set; }

        /// <summary>
        /// MessageResults property only for testing purpose.
        /// Not required in the exercise
        /// </summary>
        public List<string> MessageResults { get; set; }

        public void yearPasses()
        {
            age++;
        }

        public void amIOld()
        {
            if (age < 13)
            {
                MessageResults.Add("You are young.");
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                MessageResults.Add("You are a teenager.");
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                MessageResults.Add("You are old.");
                Console.WriteLine("You are old.");
            }
        }
    }
}
