using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverPOMExample.PageObjects;

namespace WebDriverPOMExample.Tests
{
    public class TestAddStudentPage : BaseTests
    {
        [Test]
        public void Test_TestAddStudentPage_Content()
        {
            var page = new AddStudentPage(driver);
            page.Open();

            
            Assert.That(page.FieldName.Text, Is.EqualTo(""));
            Assert.That(page.FieldEmail.Text, Is.EqualTo(""));
            Assert.That(page.GetPageTitle(), Is.EqualTo("Add Student"));
            Assert.That(page.GetPageHeadingText(), Is.EqualTo("Register New Student"));
            Assert.That(page.ButtonSubmit.Text, Is.EqualTo("Add"));

        }

        [Test]
        public void Test_TestAddStudentPage_Links()
        {
            var addStudentPage = new AddStudentPage(driver);
            addStudentPage.Open();

            addStudentPage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).isOpen());

            addStudentPage.LinkAddStudentPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).isOpen());

            addStudentPage.LinkViewStudentsPage.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).isOpen());

           

           
        }

        [Test]
        public void Test_TestAddStudentPage_AddValidStudent() 
        {
            var page = new AddStudentPage(driver);
            page.Open();
            string name = "Pesho" + DateTime.Now.Ticks;
            string email = "pesho" + DateTime.Now.Ticks + "@gmail.com";

            page.AddStudent(name, email);
            var viewStudentsPage = new ViewStudentsPage(driver);

            Assert.IsTrue(viewStudentsPage.isOpen());
            var students = viewStudentsPage.GetRegisteredStudents();
            string newStudent = name + " (" + email + ")";

            Assert.Contains(newStudent, students);


        }



    }
}
