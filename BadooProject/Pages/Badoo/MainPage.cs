using System;
using BadooProject.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages.Badoo
{
    public class MainPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//span[@data-choice='yes']")] private IWebElement likeButton;
        [FindsBy(How = How.XPath, Using = "//h1[.='Больше симпатий']")] private IWebElement moreLikes;
        [FindsBy(How = How.XPath, Using = "//span[@data-choice='no']")] private IWebElement dislikes;

        public MainPage LikePages()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    likeButton.Click();
                }
            }
            catch (Exception    e)
            {
                return this;
            }
            return this;
        }

        public MainPage ExecuteJs()
        {
            Browser.ExecuteJs("arguments[0].style.backgroundColor = 'green'", dislikes);
            return this;
        }
    }
}
