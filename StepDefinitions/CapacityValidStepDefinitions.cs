using System;
using BLinkIconsProject.Pages;
using Io.Cucumber.Messages.Types;
using Microsoft.Playwright;
using Reqnroll;
using BLinkIconsProject.StepDefinitions;
using System.Threading.Tasks;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class CapacityValidStepDefinitions0(Hooks hooks, CapacityPage capacityPage)

    {
        private readonly IPage _page = hooks.Page;
        private readonly CapacityPage  _capacityPage = capacityPage;

        [Given("the user navigates to  BLinkIcons website {string}")]
        public async Task GivenTheUserNavigatesToBLinkIconsWebsite(string url)
        {
            await _capacityPage.GoTo(url);
        }

        [When("the user clicks on capacity item")]
        public async Task WhenTheUserClicksOnCapacityItem()
        {
            await _capacityPage.clickCapacityItem();
        }

        [Then("the user should be directed to the cpacity page displaying {string}")]
        public async Task ThenTheUserShouldBeDirectedToTheCpacityPageDisplaying(string p0)
        {
           await _capacityPage.validateMessage(p0);
        }

    }
}
