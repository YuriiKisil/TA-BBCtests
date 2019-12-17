using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace BBCframework3
{
    class SearchPage : BasePage
    {
        
        
            [FindsBy(How = How.XPath, Using = ".//section[@id ='search-content']//h1/a")]
            private IWebElement FirstArticul;

            public string GetFirstArticul()
            {
                return FirstArticul.Text;
            }
        
    }
}
