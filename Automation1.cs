using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQA
{
    class Automation1
    {
       

        static void Main(String[] args)
        {

        }
        [SetUp]
        public void Initialization()
        {
           // PropertiesCollection.driver =new ChromeDriver();
           // PropertiesCollection.driver.Navigate().GoToUrl("https://executeautomation.com/demoste/Login.html");
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            //Login to Application
            LoginPOM pageLogin = new LoginPOM();
           // EAPOM pageEA = pageLogin.Login("execute", "Automation");
            //pageEA.btnSave.Click();

           // pageEA.FillUserForm("Kaasi", "venky", "Koushik");



            //Initialise the page by calling its reference
            EAPOM page = new EAPOM();
           // page.TxtInitial.SendKeys("Execute  test");
           // page.btnSave.Click();



            //EnterText(element,value,type)
            //Title
            /*ReusableSetMethods.SelectDropDown("TitleId", "Mr.", "Id");
            //Initial
            ReusableSetMethods.EnterText( "Initial", "executeautomation", "Name");
            Console.WriteLine("the value from my title is:" + ReusableGetMethods.GetTextFromDDL(PropertiesCollection.driver,"TitleId", "Id"));
            Console.WriteLine("The value from my Initial is:" + ReusableGetMethods.GetText(PropertiesCollection.driver,"TitleId", "Name"));
            //Click
            ReusableSetMethods.Click( "Save", "Name");*/
        }
        [TearDown]
        public void CleanUp1()
        {
            PropertiesCollection.driver.Close();
        }
    }
    }

