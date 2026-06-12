using System;
using BLinkIconsProject.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class RecognitionValidStepDefinitions(Hooks hooks, RecognitionValidPage recognitionValidPage)
    {
        private readonly IPage _page =  hooks.Page;
        private readonly RecognitionValidPage _recognitionValidPage = recognitionValidPage;

        [Given("the user navigates to BLinkIcons Website {string}")]
        public void GivenTheUserNavigatesToBLinkIconsWebsite(string url)
        {
            _recognitionValidPage.GoTo(url);
        }

        [Then("the user should see displayed the message {string}")]
        public void ThenTheUserShouldSeeDisplayedTheMessage(string message)
        {
         _recognitionValidPage.VaidateMessage(message);
        }

    }
}
