using Microsoft.AspNetCore.Mvc;
using WebDoAn.Models;

namespace WebDoAn.Controllers
{
    public class ProjectsController : Controller
    {
#pragma warning disable S4487 // Unread "private" fields should be removed
        private readonly ILogger<ProjectsController> _logger;
#pragma warning restore S4487 // Unread "private" fields should be removed
        private readonly DataContext _context;

        public ProjectsController(ILogger<ProjectsController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var projects = _context.Projects.Where(m => m.IsActive).OrderByDescending(i => i.ProjectId).ToList();
            return View(projects);
        }
        [Route("/projects-{slug}-{id:}.html", Name = "Details")]
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Details = _context.Projects.Where(i => i.ProjectId == id && i.IsActive).FirstOrDefault();
            if (Details == null)
            {
                return NotFound();
            }
           
            return View(Details);
        }
    }
}
