using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverPOMExample.PageObjects;

namespace WebDriverPOMExample.Tests
{
    public class TestViewStudentsPage : BaseTests
    {
        [Test]
        public void Test_ViewStudentPage_Content()
        {
            var page = new ViewStudentsPage(driver);
            page.Open();
            Assert.That(page.GetPageTitle, Is.EqualTo("Students"));
            Assert.That(page.GetPageHeadingText, Is.EqualTo("Registered Students"));

            var students = page.GetRegisteredStudents();

            foreach(string st in students)
            {
                Assert.IsTrue(st.IndexOf("(") > 0);
                Assert.IsTrue(st.LastIndexOf(")") == st.Length-1);
            }

        }



    }
}
