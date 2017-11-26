using BadooProject.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using static BadooProject.Utils.Browser;

namespace BadooProject.Pages
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
            GotoLastWindow();
            settings = new TestSettings();
            emailInput.SendKeys(settings.Email);
            passwordInput.SendKeys(settings.Password);
            loginButton.Click();
            GotoFirstWindow();
            return new MainPage();
        }
    }
}