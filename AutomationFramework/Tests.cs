using System;
using AutomationFramework.Helpers;
using AutomationFramework.PageObject;
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
            App.driver = new ChromeDriver();
            App.driver.Manage().Window.Maximize();
            Utils.ImplisitWait(4);
        }


        [Test]
        public void CreateAccount()
        {
            App.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            LoginPage loginPage = new LoginPage();
            loginPage.CreateAccount("oleg_rud@mail.ru");

            AccountCreationForm form = new AccountCreationForm
            {
                Gender = "Mr",
                FirstName = "Oleg",
                LastName = "Rudenko",
                Password = "1q2w3e4r",
                Date = "14",
                Month = "May",
                Year = "1986",
                Company = "USAR",
                Address = "288, Main Road",
                City = "Houston",
                State = "Texas",
                PostalCode = "77001",
                MobilePhone = "+385687569845"
            };
            Utils.WaitForExists("id_gender1");
            CreateAccount createAccount = new CreateAccount();
            createAccount.PopulatePersoanalInfo(form);

        }
        [Test]
        public void Login()
        {
            App.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            LoginPage loginPage = new LoginPage();
            loginPage.Login("oleg_ru@ukr.net", "1q2w3e4r");

        }
        [Test]
        public void CreateAccountCheckMessage()
        {
            App.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            LoginPage loginPage = new LoginPage();
            loginPage.CreateAccount("oleg_rud@mail.ru");
            Utils.WaitForVisible("create_account_error", 5);
            String text = App.driver.FindElement(By.Id("create_account_error")).GetText("Text");
            Assert.AreEqual("An account using this email address has already been registered. Please enter a valid password or request a new one.", text);

        }
        [OneTimeTearDown]
        public void CleanUp()
        {



        }

    }
}
