using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BadooProject.Pages.Badoo;
using BadooProject.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages.Vk
{
    public class UserPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//*[@id='profile_photos_module']/a[2]/div/span[1]")] private IWebElement albumsButton;

        public AlbumsPage GoToAlbums()
        {
            Browser.Goto("https://vk.com/grystney_edinorog");
            albumsButton.Click();
            return new AlbumsPage();
        }
    }
}
