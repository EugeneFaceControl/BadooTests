using BadooProject.Pages.Badoo;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages.Vk
{
    public class WelcomePage : BasePage
    {
        private const string email = "+375445537415";
        private const string password = "Vasnovparqwe2";
        [FindsBy(How = How.Id, Using = "email")] private IWebElement emailInput;

        [FindsBy(How = How.Id, Using = "pass")] private IWebElement passwordInput;
        [FindsBy(How = How.Id, Using = "login_button")] private IWebElement loginButton;

        public UserPage Login()
        {
            emailInput.SendKeys(email);
            passwordInput.SendKeys(password);
            loginButton.Click();
            return new UserPage();
        }
    }
}