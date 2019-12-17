using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;
using System.Linq;

namespace BBCframework3
{
    [Binding]
    public class SearchAllNewsByCategorySteps
    {
        SearchPage searchpage = new SearchPage();
        [Given(@"I go to NewsPage on BBC\.com")]
        public void GivenIGoToNewsPageOnBBC_Com()
        {
            new BBCMainPage().OpenBBC();
            new BBCMainPage().GoToNewspage();
        }
        
        [When(@"I see category of main News")]
        public void WhenISeeCategoryOfMainNews()
        {
            new BBCNewsPage().SearchByCategory();
        }
        
        [Then(@"I search all news of this category and check the (.*)")]
        public void ThenISearchAllNewsOfThisCategoryAndCheckThe(string p0)
        {
            string ExpectedAarticul = p0;
            Assert.AreEqual(ExpectedAarticul, searchpage.GetFirstArticul());
        }
    }
}
