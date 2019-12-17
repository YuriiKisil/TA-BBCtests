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
    class BBCNewsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//button[@ class = 'nw-c-nav__wide-morebutton nw-c-nav__wide-morebutton__closed']//span")]
        private IWebElement btnMore;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Have Your Say')]")]//li[@class = 'gs-o-list-ui__item--flush gel-long-primer nw-c-nav__wide-menuitem-container gs-u-display-block']/a[@href='/news/have_your_say']
        private IWebElement btnHaveSomeToSay;

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'promo-heading')]/child::h3")]
        private IWebElement TitleHeadNews;

        [FindsBy(How = How.XPath, Using = "(.//div[@class='gs-c-promo-body gs-u-display-none gs-u-display-inline-block@m gs-u-mt@xs gs-u-mt0@m gel-1/3@m']//span)[5]")]
        private IWebElement Category;//redo XPath

        [FindsBy(How = How.XPath, Using = " / html / body / header / div / div[1] / div[3] / form / div / input[1]")]
        private IWebElement SearchBar;//redo XPath

        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div[1]/div[3]/form/div/button")]
        private IWebElement btnSearch;//redo XPath

        private List<string> Titles = new List<string>();
        //private void ClickMore()
        //{ btnMore.Click(); }

        public void GoToHaveSomeToSayPage()
        {
            btnMore.Click();
            //btn.ClickMore();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            btnHaveSomeToSay.Click();
            driver.Navigate().GoToUrl("https://www.bbc.com/news/have_your_say");
        }

        public string GetPrimaryTitle()
        {
            return TitleHeadNews.Text;
        }

        public void UpdateTitles()
        {
            for (int i = 1; i < 6; i++)
            {
                Titles.Add(driver.FindElement(By.XPath("(//h3[@class='gs-c-promo-heading__title gel-pica-bold nw-o-link-split__text'])[" + i + "]")).Text);
            }
        }
        public bool CheckTitle(string title)
        {
            UpdateTitles();
            return Titles.Contains(title);
        }

        public void SearchByCategory()
        {
            SearchBar.SendKeys(Category.Text);
            btnSearch.Click();
        }



        //public bool CheckMainTitles(List<S>)
    }
}
