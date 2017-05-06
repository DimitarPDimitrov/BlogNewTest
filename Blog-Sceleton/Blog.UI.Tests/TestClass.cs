using NUnit.Framework;
using OpenQA.Selenium;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void ShouldLoadBlog()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(180));

            driver.Navigate().GoToUrl(BrowserHost.RootUrl);
            var logo = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a"));

            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }

        public void CheckURL()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;

            driver.Navigate().GoToUrl(BrowserHost.RootUrl);
            var browserUrl = driver.Url;

            Assert.AreEqual(@"http://localhost:60634/", browserUrl);
        }
    }
}
