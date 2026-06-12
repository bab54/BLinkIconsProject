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
    public class CompanyInformationValidPage(Hooks hooks)
    {
        private readonly IPage _page =hooks.Page;

        private ILocator AboutUs => _page.Locator("#block-11 > div > ul > li:nth-child(1)");
        private ILocator contactUs => _page.Locator("#block-11 > div > ul > li:nth-child(2)");
        private ILocator modern => _page.Locator("#block-11 > div > ul > li:nth-child(3)");
        
        private ILocator industry => _page.Locator("#block-11 > div > ul > li:nth-child(4)");
        private ILocator services => _page.Locator("#block-11 > div > ul > li:nth-child(5)");
        private ILocator news => _page.Locator("#block-11 > div > ul > li:nth-child(6)");
       
        public async Task ValidateMessage(string message)
        {
             Expect(AboutUs).ToContainTextAsync(message);
            Expect(contactUs).ToContainTextAsync(message);
            Expect(modern).ToContainTextAsync(message);
           
            Expect(industry).ToContainTextAsync(message);
            Expect(services).ToContainTextAsync(message);
            Expect(news).ToContainTextAsync(message);
        }

    }
}
