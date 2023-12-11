using Microsoft.AspNetCore.Mvc;
using WebDoAn.Models;

namespace WebDoAn.Components
{
    [ViewComponent(Name ="ProjectView")]
    public class ProjectViewComponent : ViewComponent
    {
        private readonly DataContext _context;

        public ProjectViewComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofProject = (from p in _context.Projects
                              where (p.IsActive == true)
                              select p).ToList();
           
            return await Task.FromResult((IViewComponentResult)View("Default", listofProject));
        }
    }
}
