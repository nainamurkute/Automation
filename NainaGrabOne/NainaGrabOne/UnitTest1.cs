using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestContext = NUnit.Framework.TestContext;

namespace NainaGrabOne
{
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver;
        [Test]
        public void OpenSite()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
            driver = new ChromeDriver(options);
          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.Navigate().GoToUrl("https://new.grabone.co.nz/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);

          
             OptionsProcess();
        }

        public void OptionsProcess()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            
                IWebElement lglink = driver.FindElement(By.Id("banner-account-links"));
                IList<IWebElement> gotolink = lglink.FindElements(By.TagName("li"));
                TestContext.WriteLine(gotolink);
            TestContext.WriteLine(gotolink.Count);
            
            //  int bocha = gotolink.Count;

            for (int i = 0; i < gotolink.Count; i++)
                {
                    if (gotolink[i]==gotolink[2])
                    {

                  //  driver.FindElement(By.XPath("//a[@href='https://www.grabone.co.nz/login']")).Click();

                    // gotolink[i].Click();
                    TestContext.WriteLine(gotolink[i].Text);

                   // xpath("//*[@id='campaignListTable']")).sendKeys("TEXT");

        }
            }


        }

        // [Test]
        public void LoginClick()
        {
            driver.FindElement(By.XPath("//a[@href='https://www.grabone.co.nz/login']")).Click();
               

        }


    }
}
