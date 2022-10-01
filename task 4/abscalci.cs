using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    abstract class cal
    {
        public abstract void add(int num1, int num2);

        public abstract void sub(int num1, int num2);

        public abstract void mul(int num1, int num2);
        public abstract void div(int num1, int num2);
    }
    class Ans : cal
    {
        int answer;

        public override void add(int num1, int num2)
        {
            answer=num1+num2;   
            Console.WriteLine(answer);
        }
        public override void sub(int num1, int num2)
        {
            answer = num1 - num2;
            Console.WriteLine(answer);
        }
        public override void mul(int num1, int num2)
        {
            answer = num1 * num2;
            Console.WriteLine(answer);
        }
        public override void div(int num1, int num2)
        {
            answer = num1 / num2;
            Console.WriteLine(answer);
        }
    }
    internal class abscalci
    {
        public static void Main()
        {
            Ans cal = new Ans();
            cal.add(4, 7);
            cal.sub(98, 25);
            cal.mul(78, 21);
            cal.div(18, 2);
        }
    }
}
