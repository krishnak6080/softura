using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class nameandage
    {
        public static void Main()
        {
            Console.WriteLine("What is your name");
            string name=Console.ReadLine();
            Console.WriteLine("What is your age");
            int age=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<age;i++)
                Console.WriteLine("My name is {0}",name);
        }
    }
}
