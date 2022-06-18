using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverPOMExample.PageObjects;

namespace WebDriverPOMExample.Tests
{
    internal class TestHomePage :BaseTests
    {
        [Test]
        public void Test_HomePage_Content()
        {
            var page = new HomePage(driver);
            page.Open();

            Assert.That(page.GetPageTitle(), Is.EqualTo("MVC Example"));
            Assert.That(page.GetPageHeadingText, Is.EqualTo("Students Registry"));
            page.GetStudentsCount();
        }

        [Test]
        public void Test_HomePage_Links()
        {
            var homePage = new HomePage(driver);

            homePage.Open();
            homePage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).isOpen());

            homePage.Open();
            homePage.LinkAddStudentPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).isOpen());

            homePage.Open();
            homePage.LinkViewStudentsPage.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).isOpen());  
        }

    }
}
