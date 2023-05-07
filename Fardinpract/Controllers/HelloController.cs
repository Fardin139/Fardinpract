using Fardinpract.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fardinpract.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Fardin",
                Gender = "Male"
            };
            return View(student);
        }
    }
}
