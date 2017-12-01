using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoTestsProject.WebPages
{
    public abstract class BasePage
    {
        public IWebDriver Driver => Browser.Driver();

        protected BasePage()
        {
            PageFactory.InitElements(Driver, this);
        }
    }
}
