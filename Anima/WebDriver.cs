using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Anima
{
    [TestFixture]
    public class WebDriver
    {
        public static IWebDriver driver { get; set; }

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(".");//(SeleniumUteis.SeleniumUteis.getPathSeleniumDriver());
            driver.Navigate().GoToUrl("https://automacaocombatista.herokuapp.com/home/index");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
