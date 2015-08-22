using System;

namespace WhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize the counter
            int counter = 0;

            //Execute the loop body while the loop condition holds
            while (counter <= 9)
            {
                //Print the counter value
                Console.WriteLine("Number : " + counter);
                //Increment the counter
                counter++;
            }
        }
    }
}
