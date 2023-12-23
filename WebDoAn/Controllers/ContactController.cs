﻿using Microsoft.AspNetCore.Mvc;
using WebDoAn.Models;

namespace WebDoAn.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _context;
        public ContactController(DataContext context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public bool Create(string name, string phone, string email, string message)
        {
            try
            {
                Contact contact = new Contact();
                contact.Name = name;
                contact.Phone = phone;
                contact.Email = email;
                contact.Message = message;
                contact.CreatedDate = DateTime.Now;
                _context.Add(contact);
                _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
