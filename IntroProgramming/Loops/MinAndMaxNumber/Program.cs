using System;

namespace MinAndMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count number: ");
            int n = int.Parse(Console.ReadLine()); //input number of numbers
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine("Min number is: {0}", minNumber);
            Console.WriteLine("Max number is: {0}", maxNumber);
        }
    }
}
