using System;
using BadooProject.Pages.Badoo;
using BadooProject.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BadooTests
{
    [Binding]
    public class LikerSteps : BaseTest
    {
        protected TestSettings settings = new TestSettings();

        protected RegisterPage RegisterPage => new RegisterPage();
        private LoginPage _loginPage;
        private FacebookLoginPage _facebookLoginPage;
        private MainPage _mainPage;

        [Given(@"I navigate to login page")]
        public void GivenINavigateToLoginPage()
        {
            new BaseTest().SetUp();
            Browser.Goto(settings.BaseURL);
            _loginPage = RegisterPage
                .GoToLoginPage();
        }
        
        [Given(@"I login via facebook")]
        public void GivenILoginViaFacebook()
        {
            _facebookLoginPage = _loginPage.LoginViaFacebook();
        }
        
        [When(@"I submit my user's data")]
        public void WhenISubmitMyUserSData()
        {
            _mainPage = _facebookLoginPage.Register();
        }
        
        [When(@"I like (.*) times")]
        public void WhenILikeTimes(int p0)
        {
            _mainPage.LikePages();
        }
        
        [Then(@"I see pop up window with notification")]
        public void ThenISeePopUpWindowWithNotification()
        {
            ScenarioContext.Current.Pending();
            new BaseTest().CleanUp();
        }
    }
}
