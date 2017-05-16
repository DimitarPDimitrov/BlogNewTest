using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Blog.UI.Tests.Pages.HomePage
{
    public partial class HomePage
    {
        public IWebElement blogLogo
        {
            get
            {
                return this.Driver.FindElement(By.ClassName("navbar-brand"));
            }
        }
    }
}