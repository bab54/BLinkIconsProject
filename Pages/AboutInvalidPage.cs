using BLinkIconsProject.StepDefinitions;
using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Playwright.Assertions;

namespace BLinkIconsProject.Pages
{
   public class AboutInvalidPage(Hooks hooks)
    {
        private readonly IPage _page = hooks.Page;
        public ILocator valuesItems => _page.Locator("#menu-item-1970 > a");
        private ILocator message1 => _page.Locator("//*[@id=\"post-1964\"]/div[2]/div/div[1]/div/div[1]/h2");

        public async Task GoTo(string url)
        {
            await _page.GotoAsync(url);
          
        }

        public async Task clickValueItem()
        {
            await valuesItems.ClickAsync();
        }
        public async Task validateMessage(string message)
        {
            await Expect(message1).Not.ToContainTextAsync(message);
            
        }

    }
}
