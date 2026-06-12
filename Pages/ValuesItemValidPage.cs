using BLinkIconsProject.StepDefinitions;
using Io.Cucumber.Messages.Types;
using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static Microsoft.Playwright.Assertions;


namespace BLinkIconsProject.Pages
{
    public class ValuesItemValidPage(Hooks hooks)
    {
        private readonly IPage _page = hooks.Page;

        public ILocator valuesItems => _page.Locator("#menu-item-1970 > a");
        public ILocator Message1 => _page.Locator("//*[@id=\"post-1964\"]/div[2]/div/div[1]/div/div[1]/h2");
        public async Task GoTo(string url)
        {
            await _page.GotoAsync(url);
        }
        public async Task ClickValueItem()
        {
          
            await valuesItems.ClickAsync();
        }

        public async Task ValidateMessage(string message)
        {
           
            await Expect(Message1).ToContainTextAsync(message);


        }
    }
}
