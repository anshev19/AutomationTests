using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoTestsProject.WebPages
{
    class AdminPortalPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = @"//input[@name='username']")]
        protected IWebElement UsernameInp { get; set; }

        [FindsBy(How = How.XPath, Using = @"//input[@name='password']")]
        protected IWebElement PasswordInp { get; set; }

        [FindsBy(How = How.XPath, Using = @"//button[@name='login']")]
        protected IWebElement LoginBtn { get; set; }

        public void Invoke()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["AdminPortalUrl"]);
        }

        public void Login()
        {
            UsernameInp.SendKeys(ConfigurationManager.AppSettings["AdminName"]);
            PasswordInp.SendKeys(ConfigurationManager.AppSettings["AdminPswd"]);
            LoginBtn.Click();
        }
    }
}
