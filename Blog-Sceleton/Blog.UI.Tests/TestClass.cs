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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

           // driver.Navigate().GoToUrl(BrowserHost.RootUrl);
            //var title = driver.FindElement(By.TagName("title"));
            var title = wait.Until(w =>w.FindElement(By.TagName("title")));
            Assert.AreEqual("List - My ASP.NET Application", title.Text);
        }

        [Test]
        public void CheckYearText()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            
           // driver.Navigate().GoToUrl(BrowserHost.RootUrl);
            var year = driver.FindElement(By.XPath("/html/body/div[2]/footer/p"));

            Assert.AreEqual("c 2017 - SoftUni Blog", year.Text);
        }

        [Test]
        public void CheckURL()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;

          //  driver.Navigate().GoToUrl(BrowserHost.RootUrl);
            var browserUrl = driver.Url;

            Assert.AreEqual(@"http://localhost:60634/Article/List", browserUrl);
        }
    }
}
