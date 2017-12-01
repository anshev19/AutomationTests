using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTestsProject
{
    public static class Browser
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver()
        {
            _driver = _driver ?? new ChromeDriver();
            return _driver;
        }

        public static void CloseDriver()
        {
            _driver?.Quit();
        }

        static readonly Finalizer finalizer = new Finalizer();
        private sealed class Finalizer
        {
            ~Finalizer()
            {
                CloseDriver();
            }
        }
    }
}
