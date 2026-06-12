using System;
using System.Threading.Tasks;
using BLinkIconsProject.Pages;
using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class AboutValidStepDefinitions(Hooks hooks, AboutValidPage aboutValidPage)

    {
        private readonly IPage _page = hooks.Page;
        private readonly AboutValidPage _aboutValidPage = aboutValidPage;
        [Given("a user navigates to BLinkIcons Website {string}")]
        public async Task GivenAUserNavigatesToBLinkIconsWebsite(string url)
        {
            await _aboutValidPage.GoTo(url);
        }

       




       

        [When("the user clicks on About button")]
        public async Task WhenTheUserClicksOnAboutButton()
        {
            await _aboutValidPage.clickAboutButton();
        }

        
        [Then("the user is redirected to About page {string}")]
        public void ThenTheUserIsRedirectedToAboutPage(string message)
        {
             _aboutValidPage.ValidateMessage(message);
        }
    }
}
