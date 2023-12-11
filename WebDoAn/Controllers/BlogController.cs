using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDoAn.Models;

namespace WebDoAn.Controllers
{
    public class BlogController : Controller
    {

#pragma warning disable S4487 // Unread "private" fields should be removed
        private readonly ILogger<BlogController> _logger;
#pragma warning restore S4487 // Unread "private" fields should be removed
        private readonly DataContext _context;

        public BlogController(ILogger<BlogController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var blogs = _context.Blogs.Where(m => m.IsActive).OrderByDescending(i => i.BlogID).ToList();
            ViewBag.blogComment = _context.BlogComments.Where(m => m.IsActive).ToList();
            return View(blogs);
            
        }
        [Route("/blog-{slug}-{id:}.html", Name = "blogDetails")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blogdetails = _context.Blogs.Where(i => i.BlogID == id && i.IsActive).FirstOrDefault();
            if (blogdetails == null)
            {
                return NotFound();
            }
            ViewBag.blogComment = _context.BlogComments.Where(i => i.BlogID == id && i.IsActive).OrderByDescending(i => i.CommentID).ToList();
            return View(blogdetails);
        }
       
    }
}
