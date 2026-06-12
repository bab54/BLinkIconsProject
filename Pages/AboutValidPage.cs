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
  public  class AboutValidPage(Hooks hoks)
    {
        private readonly IPage _page =hoks.Page;

        private ILocator about => _page.Locator("//*[@id=\"post-795\"]/div[2]/div/div[2]/div/div[2]/div[4]/a/span/span");
        private ILocator message => _page.Locator("//*[@id=\"post-1844\"]/div[2]/div/div[1]/div/div[1]/h2");

        public async Task GoTo(string url)
        {
            await _page.GotoAsync(url);
          
        }

        public async Task clickAboutButton()
        {
            await about.ClickAsync();
        }

        public async Task ValidateMessage(string message1)
        {
            await Expect(message).ToContainTextAsync(message1);
        }

    }
}
