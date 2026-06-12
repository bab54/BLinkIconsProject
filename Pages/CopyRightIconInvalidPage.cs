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
   public class CopyRightIconInvalidPage(Hooks hooks)
    {
       private readonly IPage _page =hooks.Page;

        private ILocator mesage2 => _page.Locator("#footer > div:nth-child(3) > div > div > div > p");

        public async Task validateMessage(string message)
        {
            await Expect(mesage2).ToHaveTextAsync(message);
        }

    }
}
