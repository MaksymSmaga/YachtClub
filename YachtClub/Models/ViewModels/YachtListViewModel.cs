using System.Collections.Generic;

namespace YachtClub.Models.ViewModels
{
    public class YachtsListViewModel
    {
        public IEnumerable<Yacht> Yachts { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
