using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void ShouldLoadBlog()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
           // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

           // driver.Navigate().GoToUrl(BrowserHost.RootUrl);
            var title = driver.FindElement(By.TagName("title"));
           // var title = wait.Until(w =>w.FindElement(By.TagName("title")));
            Assert.AreEqual("List - My ASP.NET Application", title.Text);
        }

        [Test]
        public void CheckLogo()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            
           // driver.Navigate().GoToUrl(BrowserHost.RootUrl);
            var year = driver.FindElement(By.ClassName("navbar-brand"));

            Assert.AreEqual("SOFTUNI BLOG", year.Text);
        }

        [Test]
        public void CheckURL()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;

          //  driver.Navigate().GoToUrl(BrowserHost.RootUrl);
            var browserUrl = driver.Url;

            Assert.AreEqual(@"http://localhost:10639/Article/List", browserUrl);
        }

        [Test]
        public void NavigateToBlogPostEdit()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;

            //  driver.Navigate().GoToUrl(BrowserHost.RootUrl);
            var browserUrl = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/article/header/h2/a"));
            browserUrl.Click();
            var postHead = driver.FindElement(By.ClassName("btn btn-success btn-xs"));

            Assert.AreEqual(@"Edit", postHead.Text);
        }
    }
}
