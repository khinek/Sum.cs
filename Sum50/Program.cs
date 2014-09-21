using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int sum = 0;

            while (number <= 50)
            {
                sum = number + sum;

                number++;
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
