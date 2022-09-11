using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class aops
    {
        public int num1,num2;
        public void add()
        {
              Console.WriteLine("enter the number:");
              num1 = Convert.ToInt32(Console.ReadLine());
              num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("answer: {0} ",num1+num2);
        }
        public void sub()
        {
              Console.WriteLine("enter the number:");
              num1 = Convert.ToInt32(Console.ReadLine());
              num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("answer: {0} ",num1-num2);
        }

    }
    class aops1 : aops
    {
        public void multi()
        {
              Console.WriteLine("enter the number:");
              num1 = Convert.ToInt32(Console.ReadLine());
              num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("answer: {0} ",num1*num2);
        }
        public void div()
        {
              Console.WriteLine("enter the number:");
              num1 = Convert.ToInt32(Console.ReadLine());
              num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("anwer: {0} ",num1/num2);
        }
    }
    internal class arithmeticops
    {
        public static void Main()
        {
            aops1 ops = new aops1();
            ops.add();
            ops.sub();
            ops.multi();
            ops.div();
        }
    }
}
