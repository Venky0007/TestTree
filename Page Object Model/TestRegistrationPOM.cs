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
    [TestFixture]
    public class TestRegistrationPOM
    {
        [Test]
        public void VerifyDemoAuto()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html");
            RegistrationPOM LoginAuto = new RegistrationPOM(driver);
            LoginAuto.SelectDropDown();
            LoginAuto.TypeSurName();
            LoginAuto.TypeFirstName();
            LoginAuto.TypeMiddleName();
            LoginAuto.ClickOnSaveButton();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
