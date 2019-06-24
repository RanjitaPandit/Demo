using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace Bunnings
{
    public class Driver
    {

        //Initialize the browser
       public static IWebDriver driver { get; set; }
       

        public static void Initialize()
        {

            // Launch Browser
            //IWebDriver driver = new ChromeDriver();
            IWebDriver driver = new FirefoxDriver();

            //Maximize the Browser
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.bunnings.com.au");


        }     

   
        //Close the browser
        public static void Close()
        {
            driver.Close();
        }
    }
}
