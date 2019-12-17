using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace BBCframework3
{
    [Binding]
    public class OtherNewsTitlesCheckSteps
    {
        [Given(@"I go to BBC\.com")]
        public void GivenIGoToBBC_Com()
        {
            new BBCMainPage().OpenBBC();
        }
        
        [When(@"I open news page")]
        public void WhenIOpenNewsPage()
        {
            new BBCMainPage().GoToNewspage();
        }
        
        [Then(@"I see other news titles")]
        public void ThenISeeOtherNewsTitles(Table tableStuff)
        {
            BBCNewsPage s = new BBCNewsPage();
            List<string> news = tableStuff.Rows.Select(row => row[0]).ToList();
            foreach (string item in news)
            {
                Assert.IsTrue(s.CheckTitle(item));
            }
        }
    }
}
