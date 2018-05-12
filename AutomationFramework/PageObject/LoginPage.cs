using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationFramework.PageObject
{
    
    public class LoginPage : BasePage
    {

        private IWebElement txtEmailCreateAccount => App.driver.FindElement(By.Name("email_create"));
        private IWebElement createButton => App.driver.FindElement(By.Name("SubmitCreate"));

        private IWebElement txtUserName => App.driver.FindElement(By.Name("email"));
        private IWebElement txtPassword => App.driver.FindElement(By.Name("passwd"));
        private IWebElement submitBtn => App.driver.FindElement(By.Name("SubmitLogin"));


        public void Login(string email, string password)
        {
            txtUserName.EnterText(email);
            txtPassword.EnterText(password);
            submitBtn.Click();
        }
        public void CreateAccount(string email)
        {
            txtEmailCreateAccount.EnterText(email);
            createButton.Click();
        }

    }
}
