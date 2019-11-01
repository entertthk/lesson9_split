using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the list of supplies separated by comma: ");
            string userList = Console.ReadLine();

            string[] shoppingList = userList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine($"Item {i+1}: {shoppingList[i]}");
            }


        }

        public static void
    }
}
