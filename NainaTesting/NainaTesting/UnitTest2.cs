using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NainaTesting
{
    [TestClass]
    public class UnitTest2
    {
        public IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void CreateAccount()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://gmail.com");
            driver.FindElement(By.Id("identifierId")).SendKeys("naina.murkute8@gmail.com");

            // RveJvd.snByac
            // driver.FindElement(By.ClassName("CwaK9")).Click();
            //  identifierNext
             driver.FindElement(By.Id("identifierNext")).Click();
         //   driver.FindElement(By.ClassName("Xb9hP")).SendKeys("nachiket@26");
           // EnterPassword();
        }

        //[TestMethod]
        //public void EnterPassword()
        //{
        //    driver.FindElement(By.ClassName("Xb9hP")).SendKeys("nachiket@26");
        //}
    }
}

