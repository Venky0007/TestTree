using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQA
{
    public class LoginPOM
    {
        IWebDriver driver;
        By UserName = By.Name("email");
        By PassWord = By.XPath("//*[@type='password']");
        By LoginButton = By.Name("login");

        public LoginPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUserName()
        {
            driver.FindElement(UserName).SendKeys("Venky");
        }
        public void TypePassword()
        {
            driver.FindElement(PassWord).SendKeys("Venky@9999");
        }
        public void ClickOnLoginButton()
        {
            driver.FindElement(LoginButton).Click();
        }
    }
}
