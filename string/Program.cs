using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trim()- kaotab tyhikud
            //IndexOf- aadress
            //Substring
            //Split()

            /*string fullName = "Marko Kaber ";
            Console.WriteLine($"Full name length before trim: {fullName.Length} ");

            fullName = fullName.Trim();
            Console.WriteLine($"Full name length after trim: {fullName.Length} ");

            int indexOfSpace = fullName.IndexOf(' ');
            Console.WriteLine($"Position of the space is {indexOfSpace + 1}");

            string firstName = fullName.Substring(0, indexOfSpace);
            string lastName = fullName.Substring(indexOfSpace);
            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Name: {lastName}");

            //split()
            string[] personalData = fullName.Split(' ');
            foreach(string value in personalData)
            {
                Console.WriteLine($"Value from personalData: {value}");
            }
            */


            string userName;
            Console.WriteLine("Please enter a name");
            userName = Console.ReadLine();


            splitName(userName);

            Console.ReadLine();
        }

        public static void splitName(string name)
        {
            string[] personalData = name.Split(' ');
            
            Console.WriteLine($"Firstname: {personalData[0]}");
            Console.WriteLine($"name: {personalData[1]}");
            

        }
    }
}
