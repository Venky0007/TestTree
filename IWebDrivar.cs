using OpenQA.Selenium;

namespace TestQA
{
    internal interface IWebDrivar
    {
        object FindElement(By by);
        void Close();
        object Navigate();
    }
}