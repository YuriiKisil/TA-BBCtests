using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace BBCframework3
{
   public class Browser
    {
        private static IWebDriver driver;

        public static IWebDriver Driver()
        {
            if (driver == null)
            { driver = new ChromeDriver(); }
            //driver = driver ?? new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return driver;
        }
    }
}
