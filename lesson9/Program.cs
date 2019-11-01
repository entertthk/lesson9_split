using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[5];
            names[0] = "anna";
            names[1] = "richard";
            names[2] = "john";
            names[3] = "anna";
            names[4] = "jack";

            string searchName = "anna";
            /*int counter = 0;

            foreach (string name in names)
            {
                if (name == searchName)
                {
                    counter++;
                }
            }

            Console.WriteLine($"There are {counter} {searchName} -s in the array");*/
            
            countNames(names, searchName);

            Console.ReadLine();


           
        } 
        public static void countNames(string[] searchArray, string searchWord)
            {
                
                int counter = 0;

                foreach (string word in searchArray)
                {
                    if (word == searchWord)
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"There are {counter} {searchWord}-s in the array");

        }
    }
}
