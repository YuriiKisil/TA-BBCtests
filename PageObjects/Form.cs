using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.PageObjects;


namespace BBCframework3
{
    public class Form : BasePage
    {
        private string Xpath = ".//*[contains(@placeholder,'')]";
        private Dictionary<string, string> forma;
        private bool EmptyFields = false;
        public void FillForm(Dictionary<string, string> inputs)
        {
            //private string Xpath = ".//*[contains(@placeholder,'Name')]";

            foreach (KeyValuePair<string, string> input in inputs)
            {
                Xpath = String.Format(".//*[contains(@placeholder,'{0}')]", input.Key);
                //  string xpath = ".//*[contains(@placeholder,'" + input.Key + "')]";
                driver.FindElement(By.XPath(Xpath)).SendKeys(inputs[input.Key]);
                if (input.Value == "")
                { EmptyFields = true; }
            }

        }
        public bool CheckForEmptyFields()
        {
            return EmptyFields;
        }
    }
}
