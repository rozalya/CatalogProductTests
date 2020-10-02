using CatalogProductTests.Pages.HomePage;
using CatalogProductTests.Pages.ProductCatalogPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace CatalogProductTests.Tests.MainMenuTests
{
    [Binding]
    public class MainMenuSteps
    {
        private readonly HomePage homePage;
        private readonly ProductCatalogPage productCatalogPage;
        private readonly IWebDriver driver;
        private string pageNumber;

        public MainMenuSteps(HomePage homePage, ProductCatalogPage productCatalogPage, IWebDriver driver)
        {
            this.homePage = homePage;
            this.productCatalogPage = productCatalogPage;
            this.driver = driver;
        }

        [Given(@"cockies are accepted")]
        public void GivenCockiesAreAccepted()
        {
            this.homePage.AcceptCookie();
        }
        [Then(@"product catalog is loaded")]
        public void ThenProductCatalogIsLoaded()
        {
            HomePageAsserter.AssertCatalogIsVisible(this.homePage.DemoContainer);
        }


        [Given(@"Refresh button is clicked")]
        public void GivenRefreshButtonIsClicked()
        {
            this.homePage.RefreshButton.Click();
        }

        [When(@"Defualt menu settings are cleared")]
        public void WhenDefualtMenuSettingsAreCleared()
        {
            this.homePage.ParametersAreaButton.Click();
            this.homePage.DocumentMapButton.Click();
        }
        [Then(@"The page is refreshed")]
        public void ThenThePageIsRefreshed()
        {
            HomePageAsserter.AssertCatalogIsVisible(this.homePage.PageLoadingConfirmationMessage);
        }
        [Then(@"Next page button is clicked")]
        public void ThenNextPageButtonIsClicked()
        {
            HomePageAsserter.AssertPageHeaderIsVisible(this.homePage.TableOfContentHeader.Text, "Table of Contents");
            pageNumber = this.homePage.PageNumber;
            this.homePage.PageNumber = string.Empty;
            this.homePage.NextPageButton.Click();
            HomePageAsserter.AssertPageHeaderIsVisible(this.productCatalogPage.CatalogHeader.Text, "Product Catalog");
        }
        [Then(@"The next page is displayed")]
        public void ThenTheNextPageIsDisplayed()
        {
            new WebDriverWait(this.driver, System.TimeSpan.FromSeconds(5.00)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(this.homePage.CurrentPageNumber, this.pageNumber));
            var currentPageNumber = this.homePage.PageNumber;
            HomePageAsserter.AssertNextPageIsVisible(int.Parse(pageNumber), int.Parse(currentPageNumber));
           
        }
        [Then(@"The chosen page is displayed")]
        public void ThenTheChosenPageIsDisplayed()
        {
            new WebDriverWait(this.driver, System.TimeSpan.FromSeconds(5.00)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(this.homePage.CurrentPageNumber, this.pageNumber));
            var currentPageNumber = this.homePage.PageNumber;
            HomePageAsserter.AssertNextPageIsVisible(int.Parse(pageNumber), int.Parse(currentPageNumber));
        }


        [Then(@"Export of (.*) is in progress")]
        public void ThenExportOfIsInProgress(string option)
        {
            this.homePage.ExportDocument(option);
        }

        [Then(@"Export is in progress")]
        public void ThenExportIsInProgress()
        {
            HomePageAsserter.AssertProcessIsInProgress(this.homePage.ExportConfirmationMessage.Text, "Preparing document to download. Please wait...");
        }

        [Then(@"Print button is clicked")]
        public void ThenPrintButtonIsClicked()
        {
            this.homePage.PrintButton.Click();
        }

        [Then(@"Print file is in progress")]
        public void ThenPrintFileIsInProgress()
        {
            HomePageAsserter.AssertProcessIsInProgress(this.homePage.PrintConfirmationMessage.Text, "Preparing document to print. Please wait...");
        }
        [Then(@"click on link")]
        public void ThenClickOnLink()
        {
            var links = this.homePage.TableOfContentLinks;
            var rnd = new Random().Next(links.Count - 1);
            var selectedElement = links[rnd];
            this.pageNumber = selectedElement.Text;
            this.homePage.MoveToSelectedElement(selectedElement);
            selectedElement.Click();
        }
        [Then(@"selected page is visible")]
        public void ThenSelectedPageIsVisible()
        {
           
        }
    }
}
