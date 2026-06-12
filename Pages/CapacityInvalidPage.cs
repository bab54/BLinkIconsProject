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
   public class CapacityInvalidPage(Hooks hooks)
    {
        private readonly IPage _page = hooks.Page;
        public ILocator aboutItems => _page.Locator("#menu-item-1859 > a");
        public ILocator Message1 => _page.Locator("//*[@id=\"post-1844\"]/div[2]/div/div[1]/div/div[1]/h2");

        public async Task GoTo(string url)
        {
            await _page.GotoAsync(url);
        }
        public async Task ClickAboutItem()
        {

            await aboutItems.ClickAsync();
        }

        public async Task InvalidateMessage(string message)

        {
           
            await Expect(Message1).Not.ToContainTextAsync(message);
          


        }

    }
}
