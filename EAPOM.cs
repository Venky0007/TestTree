using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQA
{
    class EAPOM
    {
        internal object txtInitial;

       /* public EAPOM()
        {
            PageFactory.InitElements(PropertiesCollection.driver,this);
        }
        
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddlename { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm( string initial, string middlename, string firstname)
        {
            TxtInitial.SendKeys(initial);
            txtFirstName.SendKeys(firstname);
            txtMiddlename.SendKeys(middlename);
            btnSave.Click();
        }*/
    }
}
