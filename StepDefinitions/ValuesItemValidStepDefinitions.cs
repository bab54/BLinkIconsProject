using System;
using System.Threading.Tasks;
using BLinkIconsProject.Pages;
using BLinkIconsProject.StepDefinitions;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class ValuesItemValidStepDefinitions(Hooks hooks , ValuesItemValidPage valuesItemValidPage)
    {

        private readonly IPage _page = hooks.Page;
        private readonly   ValuesItemValidPage _valuesItemValidPage =  valuesItemValidPage;

        


        [Given("a user navigates to  BLinkIcons website {string}")]
        public async Task GivenAUserNavigatesToBLinkIconsWebsite(string url)
        {
            await _valuesItemValidPage.GoTo(url);
        }



        [When("a user clicks on menu item")]
        public async Task WhenAUserClicksOnMenuItem()
        {
            await _valuesItemValidPage.ClickValueItem();
        }



        [Then("the user should be directed to the values page displaying {string}")]
        public async Task ThenTheUserShouldBeDirectedToTheValuesPageDisplayingAsync(string message)
        {
            await _valuesItemValidPage.ValidateMessage(message);

        }

    }
}


