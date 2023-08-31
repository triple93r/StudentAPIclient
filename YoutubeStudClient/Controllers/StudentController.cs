using Microsoft.AspNetCore.Mvc;

namespace YoutubeStudClient.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateStudent()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult CreateStudentSemester()
        {
            return View();
        }
    }
}
