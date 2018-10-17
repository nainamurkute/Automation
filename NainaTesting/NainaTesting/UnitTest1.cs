using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;



namespace NainaTesting
{
   // [TestClass]
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver;
        WebDriverWait wait;

      

        //[TestMethod]
        [Test]
        public void OpenSite()
        {
          //  driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
          // options.UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss;
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://facebook.com");
            LogInClick();
            LogOut();
            CloseDriver();
        }

    //    [TestMethod]
    //    [Test]
        public void LogInClick()
        {
            //driver.Navigate().GoToUrl("https://facebook.com");
            driver.FindElement(By.Id("email")).SendKeys("naina.fumes");
            driver.FindElement(By.Id("pass")).SendKeys("nachiket");
            driver.FindElement(By.Id("loginbutton")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //  driver.FindElement(By.Id("u_18_5")).Click();

            //  LogOut();
            //  driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(10));
            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(500));
            // driver.SwitchTo().Alert().Dismiss();
            // Console.WriteLine("ilu");
        }

        //[TestMethod]
        //  [Test]
        public void LogOut()
        {
            driver.FindElement(By.XPath("//div[@id='userNavigationLabel']")).Click();
            // driver.FindElement(By.Id("userNavigationLabel")).Click();
            //driver.FindElement(By.Id("u_1a_5")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //   driver.FindElement(By.XPath("//*[@href='#']")).Click();
            //  driver.FindElement(By.XPath("//*[@id='u_1a_5']/span")).Click();
            //  driver.FindElement(By.XPath("//*[@id='u_17_5']]")).Click();
            try
            {
                driver.FindElement(By.PartialLinkText("Log Out")).Click();
            }
            catch
            {
                driver.FindElement(By.LinkText("Log Out")).Click();
            }
        }

        //[TestMethod]
       // [TearDown]
        public void CloseDriver()
        {
          //  driver.Close();
            driver.Quit();
        }



    }
}
