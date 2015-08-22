using System;
using System.Numerics;

namespace FactorialWithBigIntegerExaple
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            BigInteger factorial = 1;
            do
            {
                factorial *= n;
                n--;
            } 
            while (n > 0);
            Console.WriteLine("n! = " + factorial);
        }
    }
}
