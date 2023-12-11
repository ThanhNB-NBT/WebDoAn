using Microsoft.AspNetCore.Mvc;

namespace WebDoAn.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
