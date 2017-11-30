using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutoTestsProject
{
    class OpenMainPage : TestBase
    {
        [Test]
        public void Open()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["PortalUrl"]);
        }
    }
}
