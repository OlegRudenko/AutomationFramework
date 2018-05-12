using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.PageObject
{
    public class CreateAccount
    {
        private IWebElement TitleMr => App.driver.FindElement(By.Id("id_gender1"));
        private IWebElement TitleMs => App.driver.FindElement(By.Id("id_gender2"));
        private IWebElement FirstName => App.driver.FindElement(By.Id("customer_firstname"));
        private IWebElement LastName => App.driver.FindElement(By.Id("customer_lastname"));
        private IWebElement Password => App.driver.FindElement(By.Id("passwd"));
        private IWebElement Date => App.driver.FindElement(By.Id("days"));
        private IWebElement Month => App.driver.FindElement(By.Id("months"));
        private IWebElement Year => App.driver.FindElement(By.Id("years"));
        private IWebElement Company => App.driver.FindElement(By.Id("company"));
        private IWebElement Adress => App.driver.FindElement(By.Id("address1"));
        private IWebElement City => App.driver.FindElement(By.Id("city"));
        private IWebElement State => App.driver.FindElement(By.Id("id_state"));
        private IWebElement ZipCode => App.driver.FindElement(By.Id("postcode"));
        private IWebElement Country => App.driver.FindElement(By.Id("id_country"));
        private IWebElement MobilePhone => App.driver.FindElement(By.Id("phone_mobile"));
        private IWebElement RegisterBtn => App.driver.FindElement(By.Id("submitAccount"));


        public void PopulatePersoanalInfo(AccountCreationForm form)
        {
            if(form.Gender.Equals("Mr"))
                TitleMr.Click();
            else
                TitleMs.Click();

            FirstName.EnterText(form.FirstName);
            LastName.EnterText(form.LastName);
            Password.EnterText(form.Password);
            Date.EnterText(form.Date);
            Month.EnterText(form.Month);
            Year.EnterText(form.Year);
            Company.EnterText(form.Company);
            Adress.EnterText(form.Address);
            City.EnterText(form.City);
            Adress.EnterText(form.Address);
            State.SelectDropDown(form.State);
            ZipCode.EnterText(form.PostalCode);
            MobilePhone.EnterText(form.MobilePhone);
            RegisterBtn.Click();

        }


    }
}
