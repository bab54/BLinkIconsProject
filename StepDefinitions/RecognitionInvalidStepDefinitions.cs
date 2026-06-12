using System;
using BLinkIconsProject.Pages;
using Microsoft.Playwright;
using Reqnroll;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class RecognitionInvalidStepDefinitions(Hooks hooks, RecognitionInvalidPage  recognitionInvalidPage)
    {

        private readonly IPage _page = hooks.Page;
        private readonly RecognitionInvalidPage _recognitionInvalidPage  = recognitionInvalidPage;
        [Given("the User navigates to BLinkIcons Website {string}")]
        public void GivenTheUserNavigatesToBLinkIconsWebsite(string url)
        {
            _recognitionInvalidPage.GoTo(url);
        }

        [Then("the User should not see the  displayed the message under legal in footer {string}")]
        public void ThenTheUserShouldNotSeeTheDisplayedTheMessageUnderLegalInFooter(string message)
        {
            _recognitionInvalidPage.VaidateMessage(message);
        }

    }
}
