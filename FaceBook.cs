using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestQA
{
    [TestClass]
    public class FaceBook
    {
        
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            //Opening the Google
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']")).SendKeys("C Sharp Tutorial");
           

            //opening fb 
            driver.Navigate().Refresh();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("9030823511");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Venky@4444");
            driver.FindElement(By.Name("login")).Click();
            driver.FindElement(By.XPath("//span[@class='a8c37x1j ni8dbmo4 stjgntxs l9j0dhe7 ltmttdrg g0qnabr5 ojkyduve']")).Click();
            driver.FindElement(By.XPath("//span[@class='a8c37x1j ni8dbmo4 stjgntxs l9j0dhe7 ltmttdrg g0qnabr5 ojkyduve']")).Click();
            driver.Close();


        }
    }
}
