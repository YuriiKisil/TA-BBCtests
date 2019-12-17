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
    public class BBCHaveYourSayPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = ".//h3[contains(text(),'Do you')]/parent::a")]
        private IWebElement HaveQuestion;

        public void GoToQestionForm()
        { HaveQuestion.Click(); }
    }
}
