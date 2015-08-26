using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultFromDevidingFactoriels
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long factorial = 1;
            if (n >= k)
            {
                for (long i = k + 1; i <= n; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
            else
            {
                for (long i = n + 1; i <= k; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(1 / factorial);
            }
        }
    }
}
