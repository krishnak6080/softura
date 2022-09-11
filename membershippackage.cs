using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    abstract class benefits
    {
        public abstract void package();
    }
    class silver : benefits
    {
        public override void package()
        {
            Console.WriteLine("Silver: 3days accomodation at resort");
        }
    }
    class gold : benefits
    {
        public override void package()
        {
            Console.WriteLine("Gold: 5 days accomodation at resort and 2 dinners on the house");
        }
    }
    class platinum : benefits
    {
        public override void package()
        {
            Console.WriteLine("Platinum: 7 days accomodation at resort and 5 dinners on the house");
        }
    }
    internal class membershippackage
    {
        public static void Main()
        {
            silver sil = new silver();
            sil.package();
            gold gol = new gold();
            gol.package();
            platinum plat = new platinum();
            plat.package();
        }
    }
}
