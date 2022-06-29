using Microsoft.AspNetCore.Mvc;
using System.Linq;
using YachtClub.Models;
using YachtClub.Models.ViewModels;

namespace YachtClub.Controllers
{
    // Dependency injection - approach allows the YachtController constructor to access
    // the application’s repository through the IYachtRepository interface without having
    // any need to know which implementation class has been configured:

    // HTTP-запрос -> New object YachtController -> Constructor YachtController  ->
    // Implement interface IYachtRepository-> Startup -> <IYachtRepository, FakeYachtRepository>
    // -> new object FakeRepository into Constructor YachtController.

    public class YachtController : Controller
    {
        // Internal field  - internal repository.
        private readonly IYachtRepository _repository;

        // Constructor.
        public YachtController(IYachtRepository repository)
        {
            _repository = repository;
        }

        // The PageSize field specifies 4 yachts per page.
        public int PageSize = 4;

        // Support for pagination so that the view displays a smaller number of Yachts
        // on a page and the user can move from page to page to view the overall catalog.
        /// <summary>
        /// Return the Repository into the View.
        /// </summary>
        /// <param name="yachtpage"></param>
        /// <returns>ViewResult  - PageSize objects</returns>
        public ViewResult List(int yachtPage = 1) =>

       View(new YachtsListViewModel
       {
           Yachts = _repository.Yachts
            .OrderBy(p => p.YachtID)
            .Skip((yachtPage - 1) * PageSize)
            .Take(PageSize),

           PagingInfo = new PagingInfo
           {
               CurrentPage = yachtPage,
               ItemsPerPage = PageSize,
               TotalItems = _repository.Yachts.Count()
           }
       });

    }
}
