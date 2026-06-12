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
    public   class RecognitionInvalidPage(Hooks hooks)
    {
        private readonly    IPage _page =hooks.Page;
    
        private ILocator privacy => _page.Locator("#block-12 > div > ul > li:nth-child(1)");

        public async Task GoTo(string url)
        {
            _page.GotoAsync(url);
        }

        public async Task VaidateMessage(string message)
        {
            await Expect(privacy).ToHaveTextAsync(message);
        }
    }

}

