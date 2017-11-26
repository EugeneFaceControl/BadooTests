using System;
using System.Drawing.Text;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace BadooProject.Utils
{
    public class Browser
    {
        [ThreadStatic] private static IWebDriver _webDriver;

        public static IWebDriver WebDriver => _webDriver;
        private const string Hub = "http://localhost:4444/wd/hub";

        public static void Init(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    _webDriver =
                        new ChromeDriver();
                    break;
//                case "Grid":
//                    _webDriver = new ChromeDriver();
//                    DesiredCapabilities capabilities = new DesiredCapabilities();
//                    capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
//                    capabilities.SetCapability(CapabilityType.Version, "");
//                    capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
//                    _webDriver = new RemoteWebDriver(new Uri(Hub), capabilities);
//                    break;
                default:
                    throw new Exception("Unknown browser!");
            }

            _webDriver.Manage().Window.Maximize();
        }

        public static void Goto(string url)
        {
            _webDriver.Url = url;
        }

        public static void GotoLastWindow()
        {
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.ToList().Last());
        }

        public static void GotoFirstWindow()
        {
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.ToList().First());
        }

        public static void ExplicitWaitToZero()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }

        public static void Close()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }

        public static IWebDriver SwitchToFrame(IWebElement element) => _webDriver.SwitchTo().Frame(element);

        public static void ExecuteJs(string jsString, IWebElement element)
        {
            IJavaScriptExecutor js = _webDriver as IJavaScriptExecutor;
            var result = js?.ExecuteScript(jsString, element);
            Console.WriteLine(result);
        }

        public static void ExecuteJs(string jsString)
        {
            IJavaScriptExecutor js = _webDriver as IJavaScriptExecutor;
            var result = js?.ExecuteScript(jsString);
            Console.WriteLine(result);
        }
    }
}