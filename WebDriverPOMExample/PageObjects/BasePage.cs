using OpenQA.Selenium;
using System;

namespace WebDriverPOMExample.PageObjects
{



    public class BasePage
    {

        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public virtual string PageUrl { get; }

        public IWebElement LinkHomePage =>
            driver.FindElement(By.XPath("//body/a[@href='/']"));

        public IWebElement LinkViewStudentsPage =>
            driver.FindElement(By.LinkText("View Students"));

        public IWebElement LinkAddStudentPage =>
            driver.FindElement(By.CssSelector("body > a:nth-of-type(3)"));

        public IWebElement ElementPageHeading =>
            driver.FindElement(By.CssSelector("body > h1"));

        public void Open()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool isOpen()
        {
            return driver.Url == this.PageUrl;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetPageHeadingText()
        {
            return ElementPageHeading.Text;
        }




    }
}
