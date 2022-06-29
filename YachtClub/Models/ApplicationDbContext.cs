using Microsoft.EntityFrameworkCore;

namespace YachtClub.Models
{
    // The database context class is the bridge between the application
    // and Entity Framework Core and provides access to the application’s
    // data using model objects.
    public class ApplicationDbContext : DbContext
    {
        // The DbContext base class provides access to the Entity Framework Core’s underlying functionality,
        // and the Yachts property will provide access to the Yacht objects in the database.
        // The ApplicationDbContext class is derived from DbContext and adds the properties
        // that will be used to read and write the application’s data.
        // There is only one property at the moment, which will provide access to Yacht objects.

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options) { }
        public DbSet<Yacht> Yachts { get; set; }
    }
}
