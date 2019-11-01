using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskAskNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name and year of birth separated by comma: ");
            string userInfo = Console.ReadLine();

            separateName(userInfo);

            Console.ReadLine();

        }

        public static void separateName(string list)

        {
            string[] userList = list.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            
            Console.WriteLine($"Firstname: {userList[0]}");
            Console.WriteLine($"LAstname: {userList[0]}");
            Console.WriteLine($"Age: {2019 - int.Parse(userList[2])}");


        }

    }
}
