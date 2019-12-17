using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace BBCframework3
{
    public class BBCMainPage : BasePage
    {
        //  private IWebDriver driver;
        //public BBCMainPage(IWebDriver driver):base(driver)
        //{
        //    this.driver = driver;
        //    //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    //PageFactory.InitElements(driver, this);
        //}
        //public BBCMainPage(IWebDriver driver) :base(driver)
        //{ this.driver = driver;  
        //}
        [FindsBy(How = How.XPath, Using = "//li[@class='orb-nav-newsdotcom']/a[text() ='News'][1]")]//li[@class='orb-nav-newsdotcom']//a

        private IWebElement btnNews; //{ get; set; }

        public void OpenBBC()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");
            //BasePage mainpage = new BBCMainPage(driver);
            ////driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //return new BBCMainPage(driver);
        }


        public void GoToNewspage()
        {
            btnNews.Click();
        }
    }
}
