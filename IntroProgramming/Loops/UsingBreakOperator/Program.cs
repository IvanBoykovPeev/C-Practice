using System;

namespace UsingBreakOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //"decimal" is the biggest type can hold integer values
            decimal factorial = 1;
            //Perform an "infinite loop"
            while (true)
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }
            Console.WriteLine("n! = " + factorial);
        }
    }
}
