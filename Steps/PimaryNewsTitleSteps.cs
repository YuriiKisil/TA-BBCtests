using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace BBCframework3
{
    [Binding]
    public class PimaryNewsTitleSteps
    {
        [Given(@"I go to BBC\.com web site")]
        public void GivenIGoToBBC_ComWebSite()
        {
            new BBCMainPage().OpenBBC();
        }
        
        [When(@"I go to the News Page")]
        public void WhenIGoToTheNewsPage()
        {
            new BBCMainPage().GoToNewspage();
        }
        
        [Then(@"I can see BBC New page and '(.*)'news article on page")]
        public void ThenICanSeeBBCNewPageAndNewsArticleOnPage(string p0)
        {
            string primarynewstitle = new BBCNewsPage().GetPrimaryTitle();
            string expectednewstitle = p0;
            Assert.AreEqual(primarynewstitle, expectednewstitle);
        }
    }
}
