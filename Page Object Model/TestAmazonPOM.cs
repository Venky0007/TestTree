using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestQA.Page_Object_Model
{
   public class TestAmazonPOM
    {
        [Test]
        public void VerifyDemoAuto()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://Amazon.com");
            AmazonPOM LoginAmazon = new AmazonPOM(driver);
            LoginAmazon.ClickOnSignin();
            LoginAmazon.TypeUserName();
            LoginAmazon.ClickOnContinue();
            LoginAmazon.TypePassWord();
            LoginAmazon.ClickOnLogin();
            LoginAmazon.ClickOnDropDown();
            LoginAmazon.ClickOnSearch();
            LoginAmazon.ClickOnFirstProduct();
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
