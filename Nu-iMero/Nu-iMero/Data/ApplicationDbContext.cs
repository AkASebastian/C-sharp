using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Nu_iMero.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // <-- Make sure this is inheriting IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Other DbSets if any, for your models (e.g., Users, etc.)
        // public DbSet<YourModel> YourModels { get; set; }
    }
}
