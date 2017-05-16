using NUnit.Framework;

namespace Blog.UI.Tests.Pages.HomePage
{
    public static class HomePageAsserter
    {
        public static void AssertBlogLogoText(this HomePage page)
        {
            Assert.AreEqual("SOFTUNI BLOG", page.blogLogo.Text);
        }
    }
}