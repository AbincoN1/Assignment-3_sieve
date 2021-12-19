using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_sieve
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int number;


            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            int.TryParse(input, out number);


            bool[] primeNumbers = new bool[number + 1];
            for (int i = 2; i <= number; i++)
                primeNumbers[i] = true;


            for (int i = 2; i <= number; i++)
            {
                if (primeNumbers[i])
                {
                    for (int j = i * 2; j <= number; j += i)
                    {
                        primeNumbers[j] = false;
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine("Prime numbers between 1 and " + number + ":");
            for (int i = 0; i <= number; i++)
            {
                if (primeNumbers[i] == true)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press enter to close...");
            Console.Read();
        }
    }
}