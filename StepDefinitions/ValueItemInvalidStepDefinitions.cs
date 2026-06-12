using System;
using Microsoft.Playwright;
using BLinkIconsProject.Pages;
using BLinkIconsProject.StepDefinitions;
using Reqnroll;
using System.Threading.Tasks;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class ValueItemInvalidStepDefinitions(Hooks hooks, ValueItemInvalidPage valueItemInvalidPage)
    {
        private readonly IPage _page = hooks.Page;
        private readonly ValueItemInvalidPage _valueItemInvalidPage = valueItemInvalidPage;

        [Given("a user navigates to the BLinkIcons website {string}")]
        public async Task GivenAUserNavigatesToTheBLinkIconsWebsite(string url)
        {
            await _valueItemInvalidPage.GoTo(url);
        }


        [When("a user clicks on about item")]
        public async Task WhenAUserClicksOnAboutItem()
        {
            await _valueItemInvalidPage.ClickAboutItem();
        }

        [Then("the user should not  be directed to the values page displaying {string}")]
        public async Task ThenTheUserShouldNotBeDirectedToTheValuesPageDisplaying(string message)
        {
           await _valueItemInvalidPage.InvalidateMessage(message);
        }

    }
}
