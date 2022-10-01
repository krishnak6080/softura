using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class tvchannel
    {
        public static void Main()
        {
            Console.WriteLine("Choose the package: A or B or C");
            Console.WriteLine("Package A: south special,children club, movies");
            Console.WriteLine("Package B: news,sports, movies,regional");
            Console.WriteLine("Package C: discovery,history,national");
            string package=Console.ReadLine();
            switch(package)
            {
                case "A":Console.WriteLine("The rate is 250");
                    break;
                case "B":Console.WriteLine("The rate is 450");
                    break ;
                case "C":Console.WriteLine("The rate is 150");
                    break;
                 default:Console.WriteLine("The package is not mentioned in the list");
                    break;
            }
        }
    }
}
