namespace CinemaApp.Data
{
    using CinemaApp.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Identity.Client;

    public class CinemaAppDbContext : IdentityDbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public CinemaAppDbContext(DbContextOptions<CinemaAppDbContext> options)
            : base(options)
        {
            
        }
    }
}
