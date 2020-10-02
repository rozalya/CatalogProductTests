using NUnit.Framework;
using OpenQA.Selenium;


namespace CatalogProductTests.Pages.HomePage
{
    public static class HomePageAsserter
    {
        public static void AssertCatalogIsVisible(IWebElement catalog)
        {
            Assert.IsTrue(catalog.Displayed, "Product catalog is not dispalyed!");
        }
        public static void AssertPageIsLoaded(IWebElement message)
        {
            Assert.IsTrue(message.Displayed, "Product catalog is not loaded!");
        }
        public static void AssertNextPageIsVisible(int firstNumber, int secondNumber)
        {
            Assert.IsTrue(firstNumber == (secondNumber), "Product catalog page is not changed!");
        }
        public static void AssertPageHeaderIsVisible(string headerDisplayed, string headerExpected)
        {
            Assert.IsTrue(headerDisplayed.Contains(headerExpected), $"{headerExpected} page is not dispalyed!");
        }
        public static void AssertProcessIsInProgress(string messageDisplayed, string messageExpected)
        {
            Assert.IsTrue(messageDisplayed.Contains(messageExpected), "Process is in progress message is not dispalyed!");
        }
    }
}
