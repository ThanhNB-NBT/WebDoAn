﻿using Microsoft.AspNetCore.Mvc;
using WebDoAn.Models;

namespace WebDoAn.Components
{
    [ViewComponent(Name = "MenuView")]
    public class MenuViewComponent : ViewComponent
    {
        private readonly DataContext _context;
        public MenuViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofMenu = (from m in _context.Menus
                              where (m.IsActive == true) && (m.Position == 1)
                              select m).ToList();
            //m.Position == 1 là những menu nằm phía trên
            //m.Position == 2 là những menu nằm phía dưới
            return await Task.FromResult((IViewComponentResult)View("Default", listofMenu));
        }
    }
}
