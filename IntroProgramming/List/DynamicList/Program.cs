using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    class Program
    {
        static void Main()
        {
            DynamicList shopingList = new DynamicList();
            shopingList.Add("Milk");
            shopingList.Add("Honey");
            shopingList.Add("Olives");
            shopingList.Add("Beer");
            shopingList.Remove("Olives");
            Console.WriteLine("We need to bay:");
            for (int i = 0; i < shopingList.Count; i++)
            {
                Console.WriteLine(shopingList[i]);
            }
            Console.WriteLine("Do we have to bay Bread? " + shopingList.Contains("Bread"));
        }
    }
}
