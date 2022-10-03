using Microsoft.AspNetCore.Mvc;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllEmployee()
        {
            List<Employee> emps = Employee.GetAllEmployee();
            return View(emps);
        }
        public IActionResult OneEmployee()
        {
            Employee emp = Employee.GetOneEmployee();
            return View(emp);
        }
        public IActionResult InsertEmployee()
        {
            return View();
        }
    }
}
