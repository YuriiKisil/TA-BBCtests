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
    public class FillQuestionForm141SymbolsSteps
    {
        QuestionToBBCPage QuestionPage = new QuestionToBBCPage();
        [Given(@"I open to BBC\.com")]
        public void GivenIOpenToBBC_Com()
        {
            new BBCMainPage().OpenBBC();
        }
        
        [Given(@"I go to Question page")]
        public void GivenIGoToQuestionPage()
        {
            new BBCMainPage().GoToNewspage();
            new BBCNewsPage().GoToHaveSomeToSayPage();
            new BBCHaveYourSayPage().GoToQestionForm();
        }
        
        [When(@"I fill Question form")]
        public void WhenIFillQuestionForm(Table table)
        {
            var FormParamethers = table.Rows.ToDictionary(r => r["Input"], r => r["Data"]);
            QuestionPage.FillBBCForm(FormParamethers);
        }
        
        [Then(@"I decide press Submit or not")]
        public void ThenIDecidePressSubmitOrNot()
        {
            if (QuestionPage.ChekForEmptyFields() == true)
            {
                QuestionPage.SubmitForm();
                //Assert (QuestionPage.QuestionIsSubmited);
                Assert.IsTrue(QuestionPage.QuestionIsSubmited);
            }
            else
            {
                Assert.IsTrue(!QuestionPage.QuestionIsSubmited);
            }
        }
    }
}
