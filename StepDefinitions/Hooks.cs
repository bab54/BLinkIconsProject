using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinkIconsProject.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        public IPage Page { get; private set; } = null!;

        [BeforeScenario]
        public async Task SetupTestAsync()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Chromium.LaunchAsync(new() { Headless = false });
            IBrowserContext context = await browser.NewContextAsync();

            Page = await context.NewPageAsync();
        }
    }
}

