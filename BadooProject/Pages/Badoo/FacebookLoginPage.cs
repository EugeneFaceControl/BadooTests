using BadooProject.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages.Badoo
{
    public class FacebookLoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='email']")] private IWebElement emailInput;
        [FindsBy(How = How.XPath, Using = "//input[@name='login']")] private IWebElement loginButton;
        [FindsBy(How = How.XPath, Using = "//input[@name='pass']")] private IWebElement passwordInput;
        private TestSettings settings;

        public MainPage Register()
        {
//            string currentHandle = WebDriver.CurrentWindowHandle;
            Browser.GotoLastWindow();
            settings = new TestSettings();
            emailInput.SendKeys(settings.Email);
            passwordInput.SendKeys(settings.Password);
            loginButton.Click();
            Browser.GotoFirstWindow();
            return new MainPage();
        }
    }
}