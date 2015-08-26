using System;

namespace SumOfTheFirstNNumbersInFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long curentFibonacciNumber;
            long firstNumber = 0;    //first Fibonacci number
            long secondNumber = 1;   //second Fibonacci number         
            long sum = 1;            //sum of first and second Fibonnacci numbers
            if (n == 1)
            {
                sum = firstNumber;
            }
            for (int i = 0; i < n - 2; i++) //n = n - 2, becouse first and second number we have already.
            {                
                curentFibonacciNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = curentFibonacciNumber;
                sum += curentFibonacciNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
