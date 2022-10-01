using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsoleApp
{
    internal class deserts
    {
        public static void Main()
        {
            FileStream fs = new FileStream("C:\\Users\\Krishna\\OneDrive\\Desktop\\softura\\deserts.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine("Deserts:");
            sw.WriteLine("chessecake");
            sw.WriteLine("brownie");
            sw.WriteLine("apple pie");
            sw.WriteLine("ice cream");
            sw.Flush();
            sw.Close();
            fs.Close();
            Console.WriteLine("Done");
            FileStream fs1 = new FileStream("C:\\Users\\Krishna\\OneDrive\\Desktop\\softura\\deserts.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs1.Close();
            FileInfo fi = new FileInfo("C:\\Users\\Krishna\\OneDrive\\Desktop\\softura\\deserts.txt");
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.Length);
        }
    }
}
