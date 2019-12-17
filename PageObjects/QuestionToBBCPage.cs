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
    public class QuestionToBBCPage : BasePage
    {
        public bool QuestionIsSubmited { get; set; }

        //private IWebDriver Driver => Browser.Driver();
        [FindsBy(How = How.XPath, Using = "//div[@class='long-text-input-container']//textarea")]
        private IWebElement QuestionForm;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Name']")]
        private IWebElement InputName;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Email address']")]
        private IWebElement InputEmail;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Age']")]
        private IWebElement InputAge;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Postcode']")]
        private IWebElement InputPostcode;

        [FindsBy(How = How.XPath, Using = "//button[@class='button']")]
        private IWebElement btnSubmit;

        private Form form = new Form();
        //private Dictionary<string, string> FormInfo = new Dictionary<string, string>();
        //        {
        //            { "Name", "Donald" },
        //            { "Email address", "Donald@duck" },
        //            { "Age", "50" },
        //            { "Postcode", "1111" },
        //        };
        public void EnterQuestion(string s)
        {

            QuestionForm.SendKeys(s);
        }
        //public void FillDeafultValues()
        //{
        //    InputName.SendKeys(FormInfo["Name"]);
        //    InputEmail.SendKeys(FormInfo["Email address"]);
        //    InputAge.SendKeys(FormInfo["Age"]);
        //    InputPostcode.SendKeys(FormInfo["Postcode"]);
        //}

        public void LeftEmailFieldEmpty()
        {
            InputEmail.SendKeys("");

            // ask Peter
        }
        public void LeftNameFieldEmpty()
        {
            InputName.SendKeys("");

            // ask Peter
        }

        public void SubmitForm()
        {
            btnSubmit.Click();
            QuestionIsSubmited = true;
        }

        public void FillBBCForm(Dictionary<string, string> data)
        {
            form.FillForm(data);

        }
        public bool ChekForEmptyFields()
        {
            QuestionIsSubmited = false;
            return form.CheckForEmptyFields();
        }
        //public bool QuestionIsSubmited()
        //    if 
    }
}
