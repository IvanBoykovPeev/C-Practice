using System;
using System.Collections.Generic;

namespace DecimalToBinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            if (inputNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (inputNumber > 0)
                {
                    int remainder = inputNumber % 2;
                    inputNumber /= 2;
                    result.Add(remainder);
                }
                //Print list
                result.Reverse(); //revers list
                foreach (var item in result)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }            
        }
    }
}
