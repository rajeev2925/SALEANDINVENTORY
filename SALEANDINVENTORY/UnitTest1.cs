using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;

namespace SALEANDINVENTORY
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //to launch empty Browser
            IWebDriver driver = new ChromeDriver();
            //maximizing the browser
            driver.Manage().Window.Maximize();
            // to launch application
            driver.Url = "https://in.indeed.com/";
            // enter the 'test' in job title textfield
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("testing engineer");
            //selecting the specific job title
            driver.FindElement(By.XPath("//input[@name='l']")).SendKeys("bangalore");
            //clicking on find jobs button
            driver.FindElement(By.XPath("//button[.='Find jobs']")).Click();

          //  WebElement mw = (WebElement)driver.FindElement(By.XPath("//div[@class='icl-Modal']"));
            

            //selecting perticuler company
            driver.FindElement(By.XPath("//div[.='Company']")).Click();
            driver.FindElement(By.XPath("//a[.='IBM (83)']")).Click();
            // user verifying selected company is displayed
            String acname=driver.FindElement(By.XPath("//span[.='IBM']")).Text;
            if(acname.Equals("IBM"))
            {
                System.Console.WriteLine(acname + " selected company is displayed");
            }
            else
            {
                System.Console.WriteLine(acname+" is displaying");
            }
            try { driver.FindElement(By.XPath("//button[@aria-label='close']")).Click(); }
            catch { Console.WriteLine("there is no extra window"); }

            //user is going to signin
            driver.FindElement(By.XPath("//a[.='Sign in']")).Click();
            //user click on continue with google
            driver.FindElement(By.Id("login-google-button")).Click();
            //user switching to google signin window
            String cwin=driver.CurrentWindowHandle;
         ReadOnlyCollection<string>  windows=driver.WindowHandles;
            Boolean flag = false;
            foreach(string w in windows)
            {
              
                driver.SwitchTo().Window(w);
                String AW = driver.Title;
                if (AW.Contains("Google"))
                {
                    flag = true;
                    driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("rajeev@2925gmail.com");
                    driver.FindElement(By.XPath("//span[.='Next']")).Click();
                    driver.Close();
                    break;
                }
                
            }
            if(!flag) { Console.WriteLine("searching window is not present"); }
            driver.SwitchTo().Window(cwin);
                driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("rajeev@22925gmail.com");
            //driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Rajeev@123");

            driver.Quit();

            driver.Dispose();


        }
    }
}
