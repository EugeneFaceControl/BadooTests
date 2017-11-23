using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BadooProject.Utils
{
    public class Browser
    {
        [ThreadStatic] private static IWebDriver _webDriver;

        public static IWebDriver WebDriver => _webDriver;

        public static void Init(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    _webDriver = new ChromeDriver(@"D:\1.Programming\C#\RealBadooTest\BadooProject\BadooTests\bin\Debug");
                    break;
                default:
                    throw new Exception("Unknown browser!");
            }

            _webDriver.Manage().Window.Maximize();
        }

        public static void Goto(string url)
        {
            _webDriver.Url = url;
        }

        public static void Close()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }

        public static IWebDriver SwitchToFrame(IWebElement element) => _webDriver.SwitchTo().Frame(element);
    }
}