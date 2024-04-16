using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

            List<Employee> employees = new List<Employee>()
        {
            new Employee { EmployeeID= 122  , FirstName = "maha", LastName = "salem",Email=" MAHA@gmail.com" , Department = "it"},
            new Employee { EmployeeID= 299 ,FirstName = "Amar", LastName = "alfailkawi",Email="amar@gmail.com" , Department = "it"},
             new Employee { EmployeeID= 777 , FirstName = "haya", LastName = "alqahtani",Email="haya@gmz" , Department = "it"}
        };
          
            return View(employees);
        }
    }
}
