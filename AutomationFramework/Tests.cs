using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework
{
    [TestFixture]
    public class Tests
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com";

        }

        [Test]
        public void TestMethod1()
        {



        }
        
        [OneTimeTearDown]
        public void CleanUp()
        {



        }
    }
}
