using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestQA
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(String[] args)
        { 

        }
        [SetUp]
        public void Initilization()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened Url");
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void ExecuteTest()
        {
            driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
            Console.WriteLine("Executed Test");
        }
        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Test");

        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close The Browser");
        }
    }
}
