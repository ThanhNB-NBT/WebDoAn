using Microsoft.AspNetCore.Mvc;
using WebDoAn.Models;

namespace WebDoAn.Components
{
    [ViewComponent(Name = "MemberView")]
    public class MemberViewComponent : ViewComponent
    {
        private readonly DataContext _context;
        public MemberViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofMember = (from m in _context.Members
                                where (m.IsActive == true)
                                select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofMember));
        }
    }
}