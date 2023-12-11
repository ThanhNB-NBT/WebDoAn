using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDoAn.Models;

namespace WebDoAn.Components
{ 
    [ViewComponent(Name = "AboutView")]
    public class AboutViewComponent : ViewComponent
    {
        private readonly DataContext _context;
        public AboutViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofAbout = await _context.Abouts.Where(a => a.IsActive == true).ToListAsync();
            var listofMemberMessage = await _context.Members.Where(m => m.IsActive == true).ToListAsync();

            ViewData["Abouts"] = listofAbout;
            ViewData["Members"] = listofMemberMessage;

            return View();

        }
        

    }
}
