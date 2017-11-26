using BadooProject.Utils;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages.Badoo
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Browser.WebDriver, this);
        }
    }
}
