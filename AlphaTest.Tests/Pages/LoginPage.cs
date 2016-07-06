using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphaTest.Tests.Pages;
using AlphaTestFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;

namespace AlphaTest.Tests
{
   public class LoginPage : BasePage
    {
        //PageObjects
        [FindsBy(How = How.Id, Using = "txtLUNm")]
        IWebElement EmailElement { get; set; }
        [FindsBy(How = How.Id, Using = "txtLPass")]
        IWebElement PasswordElement { get; set; }
        [FindsBy(How = How.Id, Using = "btnlogon")]
        IWebElement btnLoginElement { get; set; }
        [FindsBy(How = How.Id, Using = "kpLogImg")]
        IWebElement chkKeepLogin { get; set; }

       public HomePage Login(string email, string password)
       {
           EmailElement.SendKeys(email);
           PasswordElement.SendKeys(password);
           chkKeepLogin.Click();
           btnLoginElement.Click();
            return new HomePage();
       }

    }
}
