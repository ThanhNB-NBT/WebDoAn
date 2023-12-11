using Microsoft.AspNetCore.Mvc;
using WebDoAn.Models;

namespace WebDoAn.Controllers
{
    public class AboutController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
