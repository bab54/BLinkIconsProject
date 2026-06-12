using System;
using System.Threading.Tasks;
using BLinkIconsProject.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class CompanyInformationValidStepDefinitions(Hooks hooks, CompanyInformationValidPage companyInformationValidPage)
    {
        private readonly IPage _page =hooks.Page;
        private readonly CompanyInformationValidPage _companyInformationValidPage =companyInformationValidPage;


        [Given("the User navigates to the BLinkIcons website {string}")]
        public async Task GivenTheUserNavigatesToTheBLinkIconsWebsite(string url)
        {
           await _page.GotoAsync(url);
        }

        [Then("at the footer the user should see {string}")]
        public void ThenAtTheFooterTheUserShouldSee(string p0)
        {
            _companyInformationValidPage.ValidateMessage(p0);
        }

    }
}
