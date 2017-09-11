using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_4___FizzBuzz_Modify
{
    class Program
    {
        public static string FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz)
                {

                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(Convert.ToString(i));
                }
            }
            return "";
        }

        static void Main(string[] args)
        {
            string fizzbuzz = Program.FizzBuzz();
            Console.WriteLine(fizzbuzz);
            Console.ReadLine();
        }
    }
}
