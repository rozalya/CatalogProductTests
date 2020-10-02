using OpenQA.Selenium;
using System.Collections.Generic;


namespace CatalogProductTests.Pages.HomePage
{
    public partial class HomePage
    {
        public IWebElement CoockieContainer => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='onetrust-banner-sdk']")));
        public IWebElement AcceptCoockieBtn => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='onetrust-accept-btn-handler']")));
        public IWebElement RefreshButton => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".trv-menu-large [aria-label='Refresh']")));
        public IWebElement NextPageButton => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".trv-menu-large [aria-label='Next page']")));
        public IWebElement PrintButton => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".trv-menu-large [aria-label='Print']")));
        public IWebElement ExportButton => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".trv-menu-large [aria-label='Export']")));
        public IWebElement ExportOption(string option) => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector($".trv-menu-large [data-command-parameter='{option}']")));
        public IWebElement DocumentMapButton => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".trv-menu-large [aria-label='Toggle document map']")));
        public IWebElement ParametersAreaButton => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".trv-menu-large [aria-label='Toggle parameters area']")));
        public IWebElement CurrentPageNumber => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".trv-menu-large .k-textbox")));
        public IWebElement TableOfContentHeader => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[text()='Table of Contents']")));
        public IWebElement DemoContainer => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#demo-container")));
        public IWebElement PageLoadingConfirmationMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[text()='Done. Total 5 pages loaded.']")));
        public IWebElement ExportConfirmationMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[text()='Preparing document to download. Please wait...']")));
        public IWebElement PrintConfirmationMessage => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[text()='Preparing document to print. Please wait...']")));
    

        public IList<IWebElement> TableOfContentLinks => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector(".trTocItem [x='722.3']")));

        public string PageNumber
        {
            get => this.CurrentPageNumber.GetAttribute("value");
            set => this.CurrentPageNumber.SendKeys(value);
        }
  
    }
}