using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogProductTests.Pages.ProductCatalogPage
{
    public partial class ProductCatalogPage
    {
        public IWebElement CatalogHeader => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[text()='Product Catalog']")));
    }
}
