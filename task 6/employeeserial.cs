using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KonsoleApp
{
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int age { get; set; }
    }
    internal class employeeserial
    {
        public static void Main()
        {
            var emp = new employee()
            {
             Id = 3333,
             Name = "tommy",
             Gender = "male",
             age = 22
            };
            XmlSerializer serializer = new XmlSerializer(typeof(employee));
            using (StreamWriter stream = new StreamWriter("employee.xml"))
            {
                serializer.Serialize(stream, emp);
            }
        }
    }
}
