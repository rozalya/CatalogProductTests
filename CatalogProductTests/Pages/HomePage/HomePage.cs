using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;


namespace CatalogProductTests.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        private readonly IWebDriver driver;
        public  HomePage(IWebDriver driver)
            : base(driver)
        {
            this.driver = driver;
        }

        public void AcceptCookie()
        {
            if (this.CoockieContainer.Displayed)
            {
                this.AcceptCoockieBtn.Click();
            }
            else
            {
                throw new Exception("Accept coockeis message is not displayed!");
            }
        }
        public void MoveToSelectedElement(IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
        public void ExportDocument(string option)
        {
            this.MoveToSelectedElement(this.ExportButton);
            this.ExportButton.Click();
            switch (option)
            {
                case "PDF": this.ExportOption("PDF").Click(); break;
                case "CSV": this.ExportOption("CSV").Click(); break;
                case "Excel": this.ExportOption("XLSX").Click(); break;
                case "PowerPoint": this.ExportOption("PPTX").Click(); break;
                case "RTF": this.ExportOption("RTF").Click(); break;
                case "TIFF": this.ExportOption("IMAGE").Click(); break;
                case "World": this.ExportOption("DOCX").Click(); break;
            }

        }

    }
}
