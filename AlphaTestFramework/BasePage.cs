using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace AlphaTestFramework
{
    public abstract class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
    }
}
