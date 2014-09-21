using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquares.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            while (number <= 20)
            {
                Console.WriteLine(number + " " + (number * number));
                
                number++;

            }
            Console.ReadLine();
        }
    }
}
