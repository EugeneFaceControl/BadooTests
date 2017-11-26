using System;
using BadooProject.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Support.Extensions;

namespace BadooTests
{
    [TestFixture]
    public class BaseTest
    {
        protected TestSettings settings;

        [SetUp]
        public void SetUp()
        {
            settings = new TestSettings();
            BrowserInit(settings.BrowserName);
        }

        [TearDown]
        public void CleanUp()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
            {
                Browser.WebDriver.TakeScreenshot().SaveAsFile($@"{AppDomain.CurrentDomain.BaseDirectory}Images\{TestContext.CurrentContext.Test.Name}.jpg");
            }
            Browser.Close();
        }

        public void BrowserInit(string browserName)
        {
            Browser.Init(browserName);
            Browser.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(settings.ImplicitTimeout);
        }
    }
}