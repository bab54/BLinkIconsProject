using BLinkIconsProject.StepDefinitions;
using CsvHelper;
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
    public class CopyRightIconValidPage(Hooks hooks)
    {
        private readonly IPage _page = hooks.Page;

        public ILocator message => _page.Locator("#footer > div:nth-child(3) > div > div > div > p");


        public async Task ValidateMessage(string Message) {

            await Expect(message).ToContainTextAsync(Message);


            }
    }
}
