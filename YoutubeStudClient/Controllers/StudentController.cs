using Microsoft.AspNetCore.Mvc;

namespace YoutubeStudClient.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
