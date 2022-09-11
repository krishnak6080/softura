using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class vat
    {
        public void calvat(double num)
        {
            Console.WriteLine("The VAT tax is: {0}", num*0.2);
        }
    }
    class gst:vat
    {
        public void calgst(double num)
        {
            Console.WriteLine("The GST tax is: {0}", num*0.12);
        }
    }
    internal class taxcalculation
    {
        public static void Main()
        {
            gst ans = new gst();
            Console.WriteLine("Enter the amount to calculate the tax:");
            double amount = Convert.ToDouble(Console.ReadLine());
            ans.calvat(amount);
            ans.calgst(amount);
        }
    }
}
