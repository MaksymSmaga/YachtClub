using System.Collections.Generic;
using System.Linq;
using Moq;
using YachtClub.Models;
using Xunit;
using YachtClub.Controllers;

namespace YachtClub.Tests
{
    public class YachtControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            // Организация
            Mock<IYachtRepository> mock = new Mock<IYachtRepository>();

            mock.Setup(m => m.Yachts).Returns((new Yacht[] {
                                            new Yacht { YachtID = 1, Name = "P1" },
                                            new Yacht { YachtID = 2, Name = "P2" },
                                            new Yacht { YachtID = 3, Name = "P3" },
                                            new Yacht { YachtID = 4, Name = "P4" } ,
                                            new Yacht { YachtID = 5, Name = "P5" }
            })
                                                .AsQueryable<Yacht>());

            YachtController controller = new YachtController(mock.Object); 
            
            controller.PageSize = 3;

            // Действие
            IEnumerable<Yacht> result = controller.List(2).ViewData.Model as IEnumerable<Yacht>;

            // Утверждение
            Yacht[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);
        }
    }
}
