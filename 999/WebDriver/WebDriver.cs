using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace _999.WebDriver
{
    public static class WebDriver
    {
        public static string OpenNewTab(this IWebDriver driver, string url)
        {
            var windowHandles = driver.WindowHandles;
            driver.ExecuteJavaScript(string.Format("windows.open('{0},', '_blank');", url));
            var newWindowsHandles = driver.WindowHandles;
            var openedWindowHandle = newWindowsHandles.Except(windowHandles).Single();
            driver.SwitchTo().Window(openedWindowHandle);
            return openedWindowHandle;
        }
    }
}
