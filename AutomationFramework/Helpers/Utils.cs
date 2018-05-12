using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationFramework.Helpers
{
    class Utils
    {
        public static void WaitForExists(string locator)
        {
            var wait = new WebDriverWait(App.driver, TimeSpan.FromSeconds(10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locator)));
        }
        public static void WaitForVisible(string locator, double waitTimeSec)
        {
            var wait = new WebDriverWait(App.driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locator)));
        }
        public static void WaitClickable(string locator, double waitTimeSec)
        {
            var wait = new WebDriverWait(App.driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locator)));
        }
        public static void ImplisitWait(double waitTimeSec = 0)
        {
            App.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitTimeSec);

        }
    }
}
