using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphaTestFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AlphaTest.Tests
{
    [TestFixture]
    public class ChangePassword
    {

        //Validate if user is able to login with registered inputs in email and password fields.
        [Test]
        [TestCase("djotsna@gmail.com", "sairam83")]
        [TestCase("sowji_urfrd@gmail.com", "sairam")]
        public void ValidLogin(string email, string password)
        {
            Driver.driver = new ChromeDriver(@"c:\SeleniumLibrary");
          //  Driver.driver.Manage().ImplicitWait()
            Driver.driver.Url = "https://www.FirstCry.com";
            // TODO: Add your test code here
            LoginPage loginPage = new LoginPage();
            loginPage.Login(email, password);
            Assert.IsTrue(Driver.driver.FindElement(By.Id("btnlogon")).Enabled);
        }
    }
}
