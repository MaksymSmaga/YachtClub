using System.Linq;

namespace YachtClub.Models
{    // To implement inteface IYachtRepository with EF Yacht Repository.
    public class EFYachtRepository : IYachtRepository
    {
        // Internal field - context.
        private readonly ApplicationDbContext _context;

        // IYachtRepository Constructor.
        public EFYachtRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // The Yachts property in the context class returns a DbSet<Yacht> object,
        // which implements the IQueryable<T> interface and makes it easy to
        // implement the IYachtRepository interface when using Entity Framework Core.

        /// <summary>
        /// Returns IQueryable<Yacht> Yachts from Context
        /// </summary>
        public IQueryable<Yacht> Yachts => _context.Yachts;
    }
}

