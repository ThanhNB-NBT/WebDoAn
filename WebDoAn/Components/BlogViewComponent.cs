using Microsoft.AspNetCore.Mvc;
using WebDoAn.Models;

namespace WebDoAn.Components
{
    [ViewComponent(Name = "BlogView")]
    public class BlogViewComponent : ViewComponent
    {
        private readonly DataContext _context;
        public BlogViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofBlog = (from b in _context.Blogs
                              where (b.IsActive == true)
                              select b).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofBlog));
        }
    }
}
