using BLinkIconsProject.StepDefinitions;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Playwright.Assertions;


namespace BLinkIconsProject.Pages
{
   public class RecognitionValidPage(Hooks hooks)
    {
        private readonly IPage _page =hooks.Page;

        private ILocator heading => _page.Locator("//*[@id=\"post-795\"]/div[2]/div/div[5]/div/div/div/h2");
        private ILocator message => _page.Locator("//*[@id=\"post-795\"]/div[2]/div/div[6]/div/div[2]/div/div[2]");

        public async Task GoTo(string url)
        {
            _page.GotoAsync(url);   
        }

        [Then("the user should see the header {string}")]
        public async Task ThenTheUserShouldSeeTheHeader(string message)
        {
            await Expect(heading).ToHaveTextAsync(message);
        }


        public async Task VaidateMessage(string message1)
        {
            await Expect(message).ToHaveTextAsync(message1);
        }
    }
}
