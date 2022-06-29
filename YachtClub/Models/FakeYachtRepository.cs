using System.Collections.Generic;
using System.Linq;

namespace YachtClub.Models
{
    // To implement inteface IYachtRepository with fake Repository.
    public class FakeYachtRepository : IYachtRepository
    {
        // The AsQueryable method is used to convert the fixed collection
        // of objects List<Yacht> to an IQueryable <Yacht>.
        public IQueryable<Yacht> Yachts => new List<Yacht>
            {new Yacht { Name = "2022 Greenline 68 OceanClass", Price = 2521924m },
             new Yacht { Name = "2021 Spirit Yachts 65DH", Price = 2776698m},
             new Yacht { Name = "2016 Prestige 680", Price = 1572639m  }
        }.AsQueryable<Yacht>();
    }
}
