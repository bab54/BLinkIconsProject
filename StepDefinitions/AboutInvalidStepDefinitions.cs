using System;
using System.Threading.Tasks;
using BLinkIconsProject.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class AboutInvalidStepDefinitions(Hooks hooks, AboutInvalidPage aboutInvalidPage)
    {
        private readonly IPage _page =hooks.Page;

        private readonly AboutInvalidPage _aboutInvalidPage =aboutInvalidPage;  
        [Given("the  user navigates to BLinkIcons Website {string}")]
        public async Task GivenTheUserNavigatesToBLinkIconsWebsite(string url)
        {
          await _aboutInvalidPage.GoTo(url);
        }

        [When("the user clicks on values button")]
        public async Task WhenTheUserClicksOnValuesButton()
        {
            await _aboutInvalidPage.clickValueItem();
        }

        [Then("the user is  not redirected to About page {string}")]
        public async Task ThenTheUserIsNotRedirectedToAboutPage(string message)
        {
            await _aboutInvalidPage.validateMessage(message);
        }

    }
}
