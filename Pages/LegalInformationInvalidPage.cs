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
    public class LegalInformationInvalidPage(Hooks hooks)
    {
        private readonly IPage _page =hooks.Page;
        private ILocator AboutUs => _page.Locator("#block-11 > div > ul > li:nth-child(1)");
        private ILocator contactUs => _page.Locator("#block-11 > div > ul > li:nth-child(2)");
        private ILocator modern => _page.Locator("#block-11 > div > ul > li:nth-child(3)");

        private ILocator industry => _page.Locator("#block-11 > div > ul > li:nth-child(4)");


        public  async Task GoTo(string url)
        {
            await _page.GotoAsync(url);
        }

        public async Task ValidateMessage(string message)
        {
              await Expect(AboutUs).Not.ToHaveTextAsync(message);
            await Expect(contactUs).Not.ToHaveTextAsync(message);
            await Expect(modern).Not.ToHaveTextAsync(message);
            await Expect(industry).Not.ToHaveTextAsync(message);
        }
    }
}
