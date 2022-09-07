using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class percentage
    {
        public static void Main()
        {
            int total = 0;
            int percent;
            int[] arr = new int[5];
            Console.WriteLine("Enter the marks of 5 subjects:");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the marks");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                total = total + arr[i];
            }
            percent = total / 5;
            Console.WriteLine("The total is:" + total);
            Console.WriteLine("The percentage is:" + percent);
        }
    }
}
