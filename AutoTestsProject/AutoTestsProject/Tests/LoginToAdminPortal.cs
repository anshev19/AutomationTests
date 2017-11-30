using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTestsProject.WebPages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTestsProject.Tests
{
    class LoginToAdminPortal : BaseTest
    {
        [Test]
        public void Login()
        {
            OpenAdminPortal();
            var adminPortalPage = new AdminPortalPage(Driver);
            adminPortalPage.Login();
        }
    }
}
