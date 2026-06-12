using System;
using System.Threading.Tasks;
using BLinkIconsProject.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class LegalInformationInvalidStepDefinitions(Hooks hooks, LegalInformationInvalidPage legalInformationInvalidPage)
    {
        private readonly IPage _page =hooks.Page;
        private readonly LegalInformationInvalidPage _legalInformationInvalidPage =legalInformationInvalidPage ;

        [Given("a  User navigates to  BLinkIcons Website {string}")]
        public async Task GivenAUserNavigatesToBLinkIconsWebsite(string url)
        {
          await  _legalInformationInvalidPage.GoTo(url);
        }

        [Then("at the footer under company information   the User should not see {string}")]
        public async Task ThenAtTheFooterUnderCompanyInformationTheUserShouldNotSee(string message)
        {
          await  _legalInformationInvalidPage.ValidateMessage(message);
        }

    }
}
