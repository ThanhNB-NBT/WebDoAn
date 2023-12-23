using Microsoft.AspNetCore.Mvc;
using WebDoAn.Models;

namespace WebDoAn.Areas.Admin.Components
{
    [ViewComponent(Name = "AdminMenu")]
    public class MenuAdminComponent : ViewComponent
    {
        private readonly DataContext _context;
        public MenuAdminComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var mnList = (from mn in _context.AdminMenus
                          where (mn.IsActive == true)
                          select mn).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", mnList));
        }
    }
}
