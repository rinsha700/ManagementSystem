using ManagementSystem.Utils;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReadData(string name1,string subject,string email)
        {
            Helper mail = new Helper();
            mail.FileWrite(name1, subject, email);

            return View();
        }
    }
}
