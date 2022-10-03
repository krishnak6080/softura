namespace EmployeeApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public static Employee GetOneEmployee()
        {
            Employee empl = new Employee()
            {
                Id = 1,
                FirstName = "White",
                LastName = "Walker",
                Gender = "Male"
            };
            return empl;
        }

        public static List<Employee> GetAllEmployee()
        {
            List<Employee> employees = new()
            {
                new Employee(){Id = 1, FirstName = "Heisen", LastName="Berg", Gender="Male"},
                new Employee(){Id = 2, FirstName = "Kris", LastName="Feck", Gender="Female"},
                new Employee(){Id = 3, FirstName = "David", LastName="Off", Gender="Male"},
                new Employee(){Id = 4, FirstName = "Ros", LastName="Benn", Gender="Female"},
                new Employee(){Id = 5, FirstName = "Feb", LastName="Will", Gender="Female"},
            };
            return employees;
        }
    }
}
