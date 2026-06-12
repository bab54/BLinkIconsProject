using BLinkIconsProject.StepDefinitions;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.Playwright.Assertions;

namespace BLinkIconsProject.Pages
{
  public  class CapacityPage(Hooks hooks)
    {
        private readonly IPage _page = hooks.Page;

        public ILocator capacityItem => _page.Locator("#menu-item-1606 > a");

        public ILocator message => _page.Locator("//*[@id=\"post-793\"]/div[2]/div/div[1]/div/div[1]/h2");

        public async Task GoTo(string url)
        {
            await _page.GotoAsync(url);
        }

        public async Task clickCapacityItem()
        {
            await capacityItem.ClickAsync();                
        }

        public async Task validateMessage(string Message1)
        {
            await Expect(message).ToContainTextAsync(Message1);
        }
    }
}
