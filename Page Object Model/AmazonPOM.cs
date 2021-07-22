using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQA.Page_Object_Model
{
    public class AmazonPOM
    {
        IWebDriver driver;
        By Sigin = By.XPath("//a[@data-ux-jq-mouseenter='true']");
        By UserName = By.Name("email");
        By Continue = By.Id("continue");
        By PassWord = By.Id("ap_password");
        By Login = By.Id("signInSubmit");
        By DropDown = By.Name("url");
        By Search = By.XPath("//input[@value='Go']");
        By FirstProduct = By.XPath("//div[@class='a-column a-span3 acs_tile acs_tile--1']");

        public AmazonPOM(IWebDriver driver)
        {
            this.driver = driver;
        }
        //Click on Sign in
        public void ClickOnSignin()
        {
            driver.FindElement(Sigin).Click();
        }
        //Type the Username
        public void TypeUserName()
        {
            driver.FindElement(UserName).SendKeys("7013192481");
        }
        //Click on continue
        public void ClickOnContinue()
        {
            driver.FindElement(Continue).Click();
        }
        //Type the Password
        public void TypePassWord()
        {
            driver.FindElement(PassWord).SendKeys("Venky@4444");
        }
        //Click on Login
        public void ClickOnLogin()
        {
            driver.FindElement(Login).Click();
        }
        //Selecting the webelement
        public void ClickOnDropDown()
        {
            IWebElement elements = driver.FindElement(DropDown);
            SelectElement element = new SelectElement(elements);
            //select by text
            element.SelectByText("Computers");
        }
        //Click on Search
        public void ClickOnSearch()
        {
            driver.FindElement(Search).Click();
        }
        //Identifying the First object
        public void ClickOnFirstProduct()
        {
            driver.FindElement(FirstProduct).Click();
        }
    }
}
