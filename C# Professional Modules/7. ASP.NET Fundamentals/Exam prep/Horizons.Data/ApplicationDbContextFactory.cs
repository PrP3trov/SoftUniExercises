using Horizons.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Horizons.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer("Server=DESKTOP-A3QGM67\\SQLEXPRESS;Database=HorizonsDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}