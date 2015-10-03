using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7,6,5,4,3,2,1};

            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("InsertionSort");
            MyLibrary.InsertionSort(arr);

            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("SelectionSort");
            MyLibrary.SelectionSort(arr);

            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
