using System;
using System.Threading.Tasks;
using BLinkIconsProject.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class CopyRightIconInvalidStepDefinitions(Hooks hooks, CopyRightIconInvalidPage copyRightIconInvalid)
    {
        private readonly IPage _page = hooks.Page;
        private readonly CopyRightIconInvalidPage _copyRightIconInvalid = copyRightIconInvalid;

        [Given("the User navigates to  BLinkIcons Website {string}")]
        public async Task GivenTheUserNavigatesToBLinkIconsWebsite(string url)
        {
            await _page.GotoAsync(url);
        }

        [Then("the user should  not see at the footer {string}")]
        public async Task ThenTheUserShouldNotSeeAtTheFooter( string message )
        {
            _copyRightIconInvalid.validateMessage(message);
        }

    }
}



