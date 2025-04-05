using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConsole
{
    public class AppDbContext : DbContext
    {
        private const string connectionString = @"Server=kraftreport\SQLEXPRESS;Database=ef_core_in_action;Trusted_Connection=True;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Book> Books { get; set; } 
    }
}
