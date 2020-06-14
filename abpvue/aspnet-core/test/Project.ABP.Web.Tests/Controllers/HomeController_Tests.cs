using System.Threading.Tasks;
using Project.ABP.Models.TokenAuth;
using Project.ABP.Web.Controllers;
using Shouldly;
using Xunit;

namespace Project.ABP.Web.Tests.Controllers
{
    public class HomeController_Tests: ABPWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}