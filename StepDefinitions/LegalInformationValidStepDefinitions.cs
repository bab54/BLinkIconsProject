using System;
using System.Threading.Tasks;
using BLinkIconsProject.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class LegalInformationValidStepDefinitions(Hooks hooks, LegalInformationValidPage legalInformationValidPage)
    {
        private readonly IPage _page = hooks.Page;
        private readonly LegalInformationValidPage _legalInformationValidPage = legalInformationValidPage;

        [Given("a  User navigates to  BLinkIcons website {string}")]
        public async Task GivenAUserNavigatesToBLinkIconsWebsite(string url)
        {
            await _legalInformationValidPage.GoTo(url);
        }

        [Then("at the footer the User should see {string}")]
        public async Task ThenAtTheFooterTheUserShouldSee(string message)
        {
            await _legalInformationValidPage.ValdateMessage(message);
        }

    }
}
