using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using WebDoAn.Models;
using System.Collections.Generic;
using WebDoAn.Areas.Admin.Models;


namespace WebDoAn.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<AdminMenu> AdminMenus { get; set; }
    }
}
