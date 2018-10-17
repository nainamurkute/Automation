using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Assert = NUnit.Framework.Assert;
using TestContext = NUnit.Framework.TestContext;

namespace NainaDropdownTesting
{
    //[TestClass]
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver;
      
       // [TestMethod]
        [Test,Order(1)]
        public void Open_Site()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://maitritomatri.com");
            ClickLink();
            DropDownValue();
            CloseBrowser();

        }

        //  [TestMethod]
      //  [Test]
       // [Test ,Order(1)]
        public void ClickLink()
        {
            // driver.FindElement(By.ClassName("drawer-menu-item whiteText")).Click();
            // driver.FindElement(By.LinkText("/membership")).Click();
            driver.FindElement(By.XPath("//a[@href='/membership']")).Click();
        }

        // [TestMethod]
        //[Test]
        public void DropDownValue()
        {
            //IWebElement dropdwnlnm = driver.FindElement(By.Name("plans"));
            //  driver.FindElement(By.Id("memPlans")).Click();
            //driver.FindElement(By.Id("DropdownId")).FindElement(By.XPath(".//option[contains(text(),'OptionText')]")).Click();
            //driver.FindElement(By.Id("memPlans")).FindElement(By.XPath(".//option[contains(text(),'4')]")).Click();

            IWebElement ddval = driver.FindElement(By.Id("memPlans"));
            IList<IWebElement> AllDropDownList = ddval.FindElements(By.XPath("//option"));

            int ddlistcount = AllDropDownList.Count;
            for( int i=0; i< ddlistcount; i++)
            {
                if(AllDropDownList[i].Text=="15")
                {
                    AllDropDownList[i].Click();
                  //  var abc = driver.FindElement(By.ClassName("amountField"));
                  //  Console.WriteLine(abc);
                  IWebElement abc = driver.FindElement(By.ClassName("amountField"));
                    object gv = abc.GetAttribute("value");
                    TestContext.WriteLine(gv);
                    object vvvv = 1000;
                    //  Assert.AreSame(vvvv,gv,"Suraj is great");
                    //  Debug.WriteLine("You only live once");
                    Assert.That(gv, Is.EqualTo("1000"));
                }
            }

            

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
