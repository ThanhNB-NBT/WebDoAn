using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

using System.Collections.Generic;

namespace WebDoAn.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }
    }
}
