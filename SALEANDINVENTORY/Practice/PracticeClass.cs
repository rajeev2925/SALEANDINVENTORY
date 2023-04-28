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
        [TestCategory("methods")]
        public void TestMethod2()
        {
            //to launch empty Browser
            IWebDriver driver = new ChromeDriver();
            // to launch application
            driver.Url = "https://whatsapp.com";
   
           

        }
    }
}
