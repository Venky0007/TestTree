using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQA.Page_Object_Model
{
   public class RegistrationPOM
    {

        IWebDriver driver;
        By DropDown = By.Id("TitleId");
        By SurName = By.Name("Initial");
        By FirstName = By.Name("FirstName");
        By MiddleName = By.Name("MiddleName");
        By Savebtn = By.Name("Save");

        public RegistrationPOM(IWebDriver driver) 
        {
            this.driver = driver;
        }
        public void SelectDropDown()
        {
            IWebElement Select = driver.FindElement(DropDown);
            SelectElement element = new SelectElement(Select);
            element.SelectByText("Mr.");//select by index
            
        }
        public void TypeSurName()
        {
            driver.FindElement(SurName).SendKeys("Kaasi");
        }
        public void TypeFirstName()
        {
            driver.FindElement(FirstName).SendKeys("Sravya");
        }
        public void TypeMiddleName()
        {
            driver.FindElement(MiddleName).SendKeys("Venky");
        }
        public void ClickOnSaveButton()
        {
            driver.FindElement(Savebtn).SendKeys("Venky");
        }

    }
}
