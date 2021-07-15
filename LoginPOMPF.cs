using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQA
{
    public class LoginPOMPF
    {
        //PageFactory --FB Login Method
        [FindsBy(How = How.Name,Using = "email")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@type='password']")]
        public IWebElement PassWord { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement LoginButton { get; set; }

        public void ClickOnLoginButton()
        {
            LoginButton.Click();
        }
    }
}
