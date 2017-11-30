using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutoTestsProject.WebPages
{
    class AdminPortalPage : BasePage
    {
        private readonly IWebDriver _driver;

        public AdminPortalPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Login()
        {
            var username = _driver.FindElement(By.XPath("//input[@name='username']"));
            var password = _driver.FindElement(By.XPath("//input[@name='password']"));
            var loginBtn = _driver.FindElement(By.XPath("//button[@name='login']"));

            username.SendKeys(ConfigurationManager.AppSettings["AdminName"]);
            password.SendKeys(ConfigurationManager.AppSettings["AdminPswd"]);
            loginBtn.Click();
        }
    }
}
