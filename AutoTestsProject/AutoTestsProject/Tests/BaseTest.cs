using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTestsProject.Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public void TestInitialize()
        {
            Driver = new ChromeDriver();
        }

        [TearDown]
        public void TestCleanup()
        {
            Driver.Quit();
        }

        public void OpenPortal()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["PortalUrl"]);
        }

        public void OpenAdminPortal()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["AdminPortalUrl"]);
        }
    }
}
