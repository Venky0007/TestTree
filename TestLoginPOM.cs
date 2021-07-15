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
   [TestFixture]
    public class TestLoginPOM
    {
        [Test]
        public void VerifyFBLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            LoginPOM Login = new LoginPOM(driver);
            Login.TypeUserName();
            Login.TypePassword();
            Login.ClickOnLoginButton();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
