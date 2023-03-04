using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment_3V2.Models;

namespace Assignment_3V2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment_3V2.Models.Actor> Actor { get; set; }
        public DbSet<Assignment_3V2.Models.Movie> Movie { get; set; }
        public DbSet<Assignment_3V2.Models.ActorMovie> ActorMovie { get; set; }
    }
}