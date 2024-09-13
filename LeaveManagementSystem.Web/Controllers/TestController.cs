using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            { Name = "Student of MVC",
             DateofBirth = new DateTime(2020,12,23)
            };
            return View(data);
        }
    }
}
