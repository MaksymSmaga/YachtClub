using System.Linq;

namespace YachtClub.Models
{
    // A class that depends on the IYachtRepository interface can obtain Yacht objects
    // without needing to know the details of how they are stored or how the implementation
    // class will deliver them.
    public interface IYachtRepository
    {
        // IQueryable<T> interface allows me to ask the database for just the objects
        // that I require using standard LINQ statements and without needing to know
        // what database server stores the data or how it processes the query.

        // We can convert IQueryable<T> to a more predictable form using
        // the ToList or ToArray extension method.
        IQueryable<Yacht> Yachts { get; }
    }
}

