using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CatalogProductTests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        public IWebDriver driver;
        private string url = ConfigurationManager.AppSettings["URL"];
        private IObjectContainer container;
        public static string ExecutionBrowser = Environment.GetEnvironmentVariable("Browser");

        public Hooks(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void CreateWebDriver()
        {
          
                this.driver = new ChromeDriver();
                this.driver.Manage().Window.Maximize();
                this.driver.Url = @"https://demos.telerik.com/reporting/product-catalog";
                this.container.RegisterInstanceAs(driver);
        }



        [AfterScenario]
        public void DestroyWebDriver()
        {
            IWebDriver driver = container.Resolve<IWebDriver>();
            driver.Quit();
            driver.Dispose();
        }

    }
}
