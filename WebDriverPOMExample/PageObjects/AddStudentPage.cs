using OpenQA.Selenium;

namespace WebDriverPOMExample.PageObjects
{
    public class AddStudentPage : BasePage
    {
        public AddStudentPage(IWebDriver driver) : base(driver)
        {

        }



        public override string PageUrl =>
            "https://mvc-app-node-express.nikolayrusev1.repl.co/add-student";

        public IWebElement FieldName =>
            driver.FindElement(By.Id("name"));
        public IWebElement FieldEmail =>
            driver.FindElement(By.Id("email"));
        public IWebElement ButtonSubmit =>
            driver.FindElement(By.CssSelector("body > form > button"));

        public IWebElement ElementRequredFieldsMessage =>
            driver.FindElement(By.XPath("//body/div[.='Cannot add student. Name and email fields are required!']"));



        public void AddStudent(string name, string email)
        {
            this.FieldName.SendKeys(name);
            this.FieldEmail.SendKeys(email);
            this.ButtonSubmit.Click();

        }



    }
}
