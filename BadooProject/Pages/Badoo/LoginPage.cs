using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages.Badoo
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'email')]")] private IWebElement emailInput;

        [FindsBy(How = How.XPath, Using = "//a[contains(@class, 'fbsession')]")] private IWebElement facebookAuth;

        [FindsBy(How = How.XPath, Using = "//span[.='Войти']/parent::*/parent::*")] private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'password')]")] private IWebElement passwordInput;

        public FacebookLoginPage LoginViaFacebook()
        {
            facebookAuth.Click();
            return new FacebookLoginPage();
        }
    }
}