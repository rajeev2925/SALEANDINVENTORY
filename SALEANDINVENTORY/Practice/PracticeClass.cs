using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALEANDINVENTORY.Practice
{
    [TestClass]
    internal class PracticeClass
    {
        [TestMethod]
        public void TestMethod2()
        {
            //to launch empty Browser
            IWebDriver driver = new ChromeDriver();
            // to launch application
            driver.Url = "https://in.indeed.com/";
            // enter the 'test' in job title textfield
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("testing engineer");
            //selecting the specific job title
            driver.FindElement(By.XPath("//input[@name='l']")).SendKeys("bangalore");
            //clicking on find jobs button
            driver.FindElement(By.XPath("//button[.='Find jobs']")).Click();
            //
           

        }
    }
}
