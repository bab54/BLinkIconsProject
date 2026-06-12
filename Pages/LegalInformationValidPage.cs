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
  public   class LegalInformationValidPage(Hooks hooks)
    {
        private readonly IPage _page = hooks.Page;
        private ILocator privacy => _page.Locator("#block-12 > div > ul > li:nth-child(1)");
        private ILocator termsOfConditions => _page.Locator("#block-12 > div > ul > li:nth-child(2)");
        private ILocator cookies => _page.Locator("#block-12 > div > ul > li:nth-child(3)");
        private ILocator termsOfUse => _page.Locator("#block-12 > div > ul > li:nth-child(4)");


        public async Task GoTo(string url)
        {
            await _page.GotoAsync(url);
        }

        public async Task ValdateMessage(string message)
        {
           await Expect(privacy).ToHaveTextAsync(message);
          await  Expect(termsOfConditions).ToHaveTextAsync(message);
          await  Expect(cookies).ToHaveTextAsync(message);
            await Expect(termsOfUse).ToHaveTextAsync(message);
        }

    }
}
