using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class multiplication
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number for tables:");
            int tables = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(tables + "*" + i + " = " + (tables*i)) ;
            }
        }
    }
}
