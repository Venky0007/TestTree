using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestQA
{
    class Amazon
    {
        //ChromeDriver Initialization
        IWebDriver driver = new ChromeDriver();
        public static void Main(String[] args) {

        }
        [SetUp]
        public void LounchBrowser()
        {
            //Navigate to Browser
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            //Maximize the Screen
            driver.Manage().Window.Maximize();
           
        }

        [Test]
        public void Pincode()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(5));
            IWebElement Address = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@id='glow-ingress-line1']")));
            IWebElement pincode = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@aria-label='or enter an Indian pincode']")));
            IWebElement ApplyButton = driver.FindElement(By.XPath("///input[@class='GLUX_Full_Width a-declarative']"));
            Address.Click();
            pincode.SendKeys("517536");
            ApplyButton.Click();

        }
        [Test]
        public void SearchForMobile()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            IWebElement SearchElement = driver.FindElement(By.XPath("//div[@class='nav-search-field ']"));
            SearchElement.SendKeys("Mobile phone");
            IWebElement Min = driver.FindElement(By.Id("low-price"));
            Min.SendKeys("10000");
            IWebElement Max = driver.FindElement(By.Id("high-price"));
            Max.SendKeys("15000");
            IWebElement ClickOnGo= driver.FindElement(By.XPath("//input[@aria-labelledby='a-autoid-1-announce']"));

        }
        [Test]
        public void SearchForLaptop()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            IWebElement SearchElement = driver.FindElement(By.XPath("//div[@class='nav-search-field ']"));
            SearchElement.SendKeys("Laptop");
            IWebElement Min = driver.FindElement(By.Id("low-price"));
            Min.SendKeys("20000");
            IWebElement Max = driver.FindElement(By.Id("high-price"));
            Max.SendKeys("30000");
            IWebElement ClickOnGo = driver.FindElement(By.XPath("//input[@aria-labelledby='a-autoid-1-announce']"));

        }
        [ClassCleanup]
        public void Close()
        {
            driver.Close();
        }
    }
}
