using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using assignment3_brandonstephens.Models;

namespace assignment3_brandonstephens.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<assignment3_brandonstephens.Models.Movie> Movie { get; set; } //must exist here to be included in db 
        public DbSet<assignment3_brandonstephens.Models.Actor> Actor { get; set; }
        public DbSet<assignment3_brandonstephens.Models.MovieActor> MovieActor { get; set; }
    }
}