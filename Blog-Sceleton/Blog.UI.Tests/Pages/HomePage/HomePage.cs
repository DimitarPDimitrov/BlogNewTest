using System;
using OpenQA.Selenium;

namespace Blog.UI.Tests.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public string URL
        {
            get
            {
                return BrowserHost.RootUrl;
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }

        public void SampleAction()
        {

        }
    }
}