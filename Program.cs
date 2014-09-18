using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any integer number from 0 to 999");
            int total = 0;
            while (true)
            {
                int I = Convert.ToInt32(Console.ReadLine());
                total += I;
                Console.WriteLine("The total is " + total);
                if (total >= 999)
                    break;
            }
                
        }
    }
}
