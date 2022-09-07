using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class flowchart
    {
        public static void Main()
        {
            string choice;
            Console.WriteLine("Do you have travel history");
            choice = Console.ReadLine();
            if (choice == "yes")
            {
                Console.WriteLine("Do you have temperature");
                choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Console.WriteLine("Do you have cough/sneeze");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        Console.WriteLine("Swab test");
                        choice = Console.ReadLine();
                    }
                    else if (choice == "no")
                        Console.WriteLine("Quarantine,Fever medicine");
                }
                else if (choice == "no")    
                    Console.WriteLine("Home quarntine for 28 days");
            }
            else if(choice == "no") 
                Console.WriteLine("Safe not covid-19");
        }
    }
}
