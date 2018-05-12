using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    enum FindBy
    {
        Id,
        Name,
        Css,
        XPath,
        Class,
        LinkText
    }

    class App
    {
        public static IWebDriver driver { get; set; }
    }
}
