using System;
using System.Threading.Tasks;
using BLinkIconsProject.Pages;
using Io.Cucumber.Messages.Types;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class CapacityInValidStepDefinitions(Hooks hooks, CapacityInvalidPage capacityInvalidPage)
    {
        private readonly IPage _page = hooks.Page;

        private readonly CapacityInvalidPage _capacityInvalidPage = capacityInvalidPage;
        [Given("the user navigates to the BLinkIcons website {string}")]
        public async Task GivenTheUserNavigatesToTheBLinkIconsWebsite(string url)
        {
            await _capacityInvalidPage.GoTo(url);
        }

        [When("the user clicks on  about item")]
        public async Task WhenTheUserClicksOnAboutItem()
        {
            await _capacityInvalidPage.ClickAboutItem();
        }


        [Then("the user should not be directed to the cpacity page displaying {string}")]
        public async Task ThenTheUserShouldNotBeDirectedToTheCpacityPageDisplaying(string message)
        {
          
            await _capacityInvalidPage.InvalidateMessage(message);
        }

    }
}
