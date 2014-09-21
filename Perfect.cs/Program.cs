using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int counter;
            int sum = 0;
            int mod;
            
            while (number <= 1000)
            {
                counter = number - 1;

                while (counter > 0)
                {
                    mod = number % counter;
                    
                    if (mod.Equals(0))
                        sum = sum + counter;

                    counter--;

                }

                if (sum.Equals(number))
                    Console.WriteLine(number);

                sum = 0;
                number++;

            }

            Console.ReadLine();
        }
    }
}
