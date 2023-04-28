using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SALEANDINVENTORY.Practice
{
    [TestClass]
    public class PracticeClass
    {
        [TestMethod]
        [TestCategory("methods")]
        public void TestMethod2()
        {
            //to launch empty Browser
            IWebDriver driver = new ChromeDriver();

            //to maximize the window
            driver.Manage().Window.Maximize();

            // to launch application using GoToUral
            driver.Navigate().GoToUrl("https://whatsapp.com");

            // to launch application
            driver.Url = "https://whatsapp.com";

            //get url of the page
            Console.WriteLine(driver.Url);
            Console.WriteLine("===============================================================================");

            //to get title of page
            Console.WriteLine(driver.Title);
            Console.WriteLine("===============================================================================");

            //to get curent page source
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("===============================================================================");

            //to get the current page
            Console.WriteLine(driver.CurrentWindowHandle);
            Console.WriteLine("===============================================================================");

            //to get the adress of element and click on that element
            driver.FindElement(By.XPath("//span[.='Privacy' and @class='_9vg3 _aj1b']")).Submit(); ;

            String curl = driver.Url;
            if (curl.Contains("privacy")) { Console.WriteLine("privacy page"); }
            else { Console.WriteLine("invalid page"); }

            //get all the links present in privacy page
            ReadOnlyCollection<IWebElement> links = driver.FindElements(By.XPath("//a/span/span"));
            Boolean flag = false;
            foreach (IWebElement link in links)
            {
                String href = link.GetAttribute("href");
                string lname = link.Text;
                if (lname.Contains("Careers"))
                { 
                    Console.WriteLine("we are in " + lname + " page");
                    link.Click();
                    flag = true;
                    break;
                }
            }
            if (!flag) { Console.WriteLine("searching libk is not present in the list "); }
        }
    }
}
