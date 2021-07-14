using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQA
{
    class Automation
    {

        IWebDriver driver = new ChromeDriver();
        static void Main(String[] args)
        {

        }
        [SetUp]
        public void Initialization()
        {
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html");
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            //EnterText(element,value,type)
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
                //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");
            Console.WriteLine("the value from my title is:" + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));
            Console.WriteLine("The value from my Initial is:" + SeleniumGetMethods.GetText(driver, "TitleId", "Name"));
            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
