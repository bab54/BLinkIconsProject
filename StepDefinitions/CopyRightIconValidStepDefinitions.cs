using System;
using System.Threading.Tasks;
using BLinkIconsProject.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class CopyRightIconValidStepDefinitions(Hooks hooks, CopyRightIconValidPage copyRightIconValidPage)
    {
        private readonly IPage _page = hooks.Page;
        private readonly CopyRightIconValidPage _copyRightIconValidPage = copyRightIconValidPage;


        [Given("the User navigates to  BLinkIcons website {string}")]
        public async Task GivenTheUserNavigatesToBLinkIconsWebsite(string url)
        {
             await  _page.GotoAsync(url);
        }

        [Then("the user should see at the footer {string}")]
        public void ThenTheUserShouldSeeAtTheFooter(string message)
        {
            _copyRightIconValidPage.ValidateMessage(message);
        }

    }
}
