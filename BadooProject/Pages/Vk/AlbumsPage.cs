using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BadooProject.Pages.Badoo;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages.Vk
{
    public class AlbumsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id = 'pva_wrap']/div[1]/div[3]")] private IWebElement savedPhotos;

        public SavedPhotosPage GoToSavedPhotos()
        {
            savedPhotos.Click();
            return new SavedPhotosPage();
        }
    }
}
