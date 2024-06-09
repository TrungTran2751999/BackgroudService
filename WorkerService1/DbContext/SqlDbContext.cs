using ConsoleApp1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SqlDbContext
{
    public class SqlDbContextClass: DbContext
    {
        public DbSet<Users> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=crud;User ID=sa;Password=123@123;");
        }
    }
}
