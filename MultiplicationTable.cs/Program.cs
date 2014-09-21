using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationTable.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 " + " 2 " + " 3 " + " 4 " + " 5 " + " 6 " + " 7 " + " 8 " + " 9 " + " 10 ");
            int firstNum = 1, secondNum = 1;

            while (firstNum <= 10)
            {

                while (secondNum <= 10)
                {
                    Console.Write((firstNum * secondNum) + " ");
                    secondNum++;
                }
                
                Console.Write("\n");
                secondNum = 1;
                firstNum++;
            }
            Console.ReadLine();
        }
    }
}
