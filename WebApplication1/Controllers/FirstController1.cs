using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FirstController1 : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello World";
            return View();
        }
        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "John";
            person.Age = 18;
            person.Location = "United States";
            return View(person);
        }
    }

}
