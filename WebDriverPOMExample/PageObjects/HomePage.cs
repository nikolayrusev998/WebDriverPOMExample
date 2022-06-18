﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverPOMExample.PageObjects
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver) 
        {

        }

        public override string PageUrl =>
            "https://mvc-app-node-express.nikolayrusev1.repl.co/";

        public IWebElement ElementStudentsCount =>
            driver.FindElement(By.CssSelector("body > p > b"));

        public int GetStudentsCount()
        {
            string studentsCountText = this.ElementStudentsCount.Text;
            return int.Parse(studentsCountText);
        }



    }
}
