using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.Helpers
{
    public static class SelenuimGetMethods
    {

        public static string GetText(this IWebElement element, string attribute)
        {
            return element.Text;

        }

        public static string GetTextFromDDl(this IWebElement element)
        {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
