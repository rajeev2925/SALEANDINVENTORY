using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SALEANDINVENTORY
{
    [TestClass]
    [TestCategory("Practice")]
    public class UnitTest2
    {
        IWebDriver driver;

      /*  [ClassInitialize]
        public void open_browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Console.WriteLine("****browser opened****");
        }
        [ClassCleanup]
        public void close_browser()
        {
            driver.Dispose();
            Console.WriteLine("****browser lost the connection****");
        }
      */
        [TestInitialize] 
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://in.indeed.com/";
            Console.WriteLine("***application opened***");
        }
        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
            Console.WriteLine("***apllication closed***");
        }
        [TestMethod]
        public void TestMethod1()
        {
            System.Console.WriteLine("***Method 1***");
        }

        [TestMethod]
        public void TestMethod2()
        {
            System.Console.WriteLine("***Method 2***");
        }
        [TestMethod]
        public void TestMethod3()
        {
            System.Console.WriteLine("***Method 3***");
        }
    }
}
