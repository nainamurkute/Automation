using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TestContext = NUnit.Framework.TestContext;

namespace TestingAliexpress
{
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver;
        [Test,Order(0)]
        public void OpenApp()
        {
            //var options = new ChromeOptions();
            //options.AddArgument("-no-sandboxs");
            //driver = new ChromeDriver("E:\\programs\\TestingAliexpress\\TestingAliexpress\\bin\\Debug", options,TimeSpan.FromSeconds(10));
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.aliexpress.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.FindElement(By.ClassName("close-layer")).Click();
          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

          //   SignInOption();
            //   driver.FindElement(By.ClassName("user-account-inner hidden-sm")).Click();
          //  driver.FindElement(By.XPath("//a[@data-role='sign-link']")).Click();

          //  Signin();

        }

        [Test,Order(1)]
        public void SignInOption()
        {
            //mouse hover for signinbuton
            HovertoOptions();
            TestContext.WriteLine("inside the div");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
           // driver.FindElement(By.LinkText("Sign in")).Click();
          //  driver.FindElement(By.XPath("//a[@data-role='sign-link']")).Click();

            TestContext.WriteLine("wow it feels good");

            //  driver.FindElement(By.ClassName("sign-btn")).Click();
            //  driver.FindElement(By.XPath("//a[@class='sign-btn']")).Click();



            IWebElement webElement = driver.FindElement(By.ClassName("flyout-user-signIn"));
            IList<IWebElement> fndsignin = webElement.FindElements(By.XPath("//a"));

            int pcount = fndsignin.Count;
            for (int i = 0; i < pcount; i++)
            {
                if (fndsignin[i].Text == "Sign in")
                {
                    fndsignin[i].Click();
                    //break;
                }
            }



        }


        [Test,Order(2)]
        public void Signin()
        {
            TestContext.WriteLine("hiii");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
           // Thread.Sleep(50000);
            TestContext.WriteLine("hii uuuui");

            IWebElement detailFrame = driver.FindElement(By.XPath("//iframe[@id='alibaba-login-box']"));
            driver.SwitchTo().Frame(detailFrame);
            TestContext.WriteLine("I am inside frame");


            IWebElement loginid = driver.FindElement(By.XPath("//input[@id='fm-login-id']"));
            loginid.SendKeys("naina.murkute12@gmail.com");
            TestContext.WriteLine("Luv u suraj");


            IWebElement passwrd = driver.FindElement(By.XPath("//input[@id='fm-login-password']"));
            passwrd.SendKeys("aayush26");
            TestContext.WriteLine("love u 2 naina");

            driver.FindElement(By.Id("login-submit")).Click();
        }

        [Test,Order(3)]
        public void ShopiingCart()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.FindElement(By.LinkText("Cart")).Click();
        }

        [Test, Order(4)]
        public void MyExpressWindow()
        {
            HovertoOptions();

            IWebElement orders = driver.FindElement(By.ClassName("flyout-quick-entry"));
            IList<IWebElement> findorders = orders.FindElements(By.TagName("a"));

            int count = findorders.Count;

            for (int i = 0; i < count; i++)
            {
                if(findorders[i].Text== "My Orders")
                {
                    findorders[i].Click();
                }

            }

        }

        [Test, Order(5)]
        public void Signout()
        {
            HovertoOptions();
            driver.FindElement(By.LinkText("Sign Out")).Click();
        }

        [Test,Order(6)]
        public void closedriver()
        {
            driver.Quit();
        }
        public void HovertoOptions()
        {
            Actions actions = new Actions(driver);
            IWebElement mousehover = driver.FindElement(By.ClassName("user-account-info"));
            actions.MoveToElement(mousehover).Perform();
        }
    }
}
