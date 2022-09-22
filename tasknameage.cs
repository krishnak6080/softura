using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsoleApp
{
    public class Details
    {
        public int age { get; set; }
        public string name { get; set; }
        public Details(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public Details(Details det)
        {
            age = det.age;
            name = det.name;
        }
        public Details()
        {
            age = 21;
            name = "Default";
        }
        public void disp()
        {
            Console.WriteLine("Name : {0}\nAge : {1}\n", name, age);
        }
    }
    internal class tasknameage
    {
        public static void Main()
        {
            Details details = new Details(101, "tommy");
            Details d1 = new Details(details);
            Details d2 = new Details() { age = 21, name = "wilbur" };
            details.disp();
            d1.disp();
            d2.disp();
            Console.WriteLine("Done");
        }
    }
}
