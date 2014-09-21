using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenNums.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            int remainder;

            while (number <= 100)
            {
                remainder = number % 2;
                if (remainder.Equals(0))
                    Console.WriteLine(number);

                number++;
            }

            Console.ReadLine();
        }
    }
}
