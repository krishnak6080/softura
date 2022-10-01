using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class jagged
    {
        public static void Main()
        {
            string[][] patients = new string[3][];
            patients[0] = new string[] { "k", "tal", "feb", "hay", "ghk" };
            patients[1] = new string[] { "day", "yall" };
            patients[2] = new string[] { "nut", "mut", "fck", "jhy", "k" };
            for (int i = 0; i < patients.Length; i++)
            {
                for (int j = 0; j < patients[i].Length; j++)
                {
                    Console.Write(patients[i][j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}
