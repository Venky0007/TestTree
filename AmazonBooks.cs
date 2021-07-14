using Amazon.DynamoDBv2;
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
    class AmazonBooks
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void AmazonMethod()
        {
            //Lounching Browser
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Test()
        {
           // Select DDL = new Select(driver.FindElement(By.Name("url")));
             IWebElement options = driver.FindElement(By.Name("url"));
            SelectElement element = new SelectElement(options);
            element.SelectByText("Books");//select by index
            //Identifying the search button
            IWebElement search = driver.FindElement(By.XPath("//input[@value='Go']"));
            search.Click();
            //identifying the first book
            IWebElement firstbook = driver.FindElement(By.XPath("//div[@id='anonCarousel1']//div[@id='acs-product-block-0']"));
            firstbook.Click();
            Console.WriteLine("Clicked the 1st Book");

        }
        [TearDown]
        public void Clean()
        {

        }
    }
}
