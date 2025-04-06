using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class MigrationFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        private const string ConnectionString = "Server=kraftreport\\SQLEXPRESS;Database=book_store;Trusted_Connection=True;TrustServerCertificate=True";
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer(ConnectionString,
                b => b.MigrationsAssembly("DataAccessLayer"));

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
