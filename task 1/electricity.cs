using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class electricity
    {
        public static void Main()
        {
            Console.WriteLine("Enter the units");
            int units=Convert.ToInt32(Console.ReadLine());
            if (units <= 200)
            {
                int amt = units * 2;
                Console.WriteLine("The number of units {0}",amt );
            }
            else if (units > 201 && units <= 350)
            {
                int units1 = units - 200;
                Console.WriteLine("The number of units {0}",400+ units1*3);
            }
            else if(units > 351 && units <= 500)
            {
                int tmpp = 200 * 2;
                int tmpp2 = 150 * 3; 
                int units2 = units-350;
                int ammt = tmpp + tmpp2 + (units2 * 5);
                Console.WriteLine("The number of units {0}",ammt);
            }
           // else if(units < 500)
            //{
             //   int units3 = units - 500;
            //}
            
        }
        
    }
}
