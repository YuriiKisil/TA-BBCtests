﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace BBCframework3
{
   public class BasePage
    {
        public IWebDriver driver { get { return Browser.Driver(); } }


        public BasePage()
        {
              PageFactory.InitElements(driver, this);
        }
    }
}
