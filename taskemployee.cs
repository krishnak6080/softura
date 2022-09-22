using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsoleApp
{
    public class PersonalDetails
    {
        string name = "X";
        char gender = ' ';
        int yearss;
        public void getdata()
        {
            Console.WriteLine("Enter name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender :");
            gender = Convert.ToChar(Console.Read());
            Console.WriteLine("Enter experience :");
            yearss = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Experience : " + yearss);
        }
    }
    public class Employee : PersonalDetails
    {
        int empID;
        int salary;
        string dept;
        public void get()
        {
            getdata();
            Console.WriteLine("Enter your employee ID :");
            empID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your salary :");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your department :");
            dept = Console.ReadLine();
        }
        public void disp()
        {
            display();
            Console.WriteLine("Employee ID : " + empID);
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Department : " + dept);
        }
        public void calcSalary()
        {
            switch (dept.ToUpper())
            {
                case "SALES & MARKETING":
                    salary = (salary * 120 / 100);
                    break;
                case "PRODUCTION":
                    salary = (salary * 110 / 100);
                    break;
                default:
                    Console.WriteLine("Error in calculating the salary...");
                    break;
            }
        }
    }
    internal class taskemployee
    {
        public static void Main()
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.get();
            e2.get();
        }
    }
}
