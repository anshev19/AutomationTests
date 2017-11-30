using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTestsProject
{
    [TestFixture]
    public abstract class TestBase
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
    }
}
