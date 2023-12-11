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
            var projectDetails = _context.Projects.FirstOrDefault(p => (p.ProjectId == id) && (p.IsActive == true));
            if (projectDetails == null)
            {
                return NotFound();
            }
            
            return View(projectDetails);
        }
    }
}
