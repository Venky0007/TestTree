using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestQA
{
    [TestFixture]
    public class TestLoginPOMPF
    {
        [Test]
        public void VerifyFBLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            LoginPOMPF LoginPF = new LoginPOMPF();
            PageFactory.InitElements(driver, LoginPF);

            LoginPF.UserName.SendKeys("Venky");
            LoginPF.PassWord.SendKeys("Venky");
            LoginPF.ClickOnLoginButton();
;           WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(5));
            driver.Quit();

        }
    }
}
