using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BadooProject.Pages.Badoo;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages.Vk
{
    public class SavedPhotosPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "pv_save_to_me")] private IWebElement savePhotoButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='pv_nav_btn_right']/div")] private IWebElement toTheRightButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='pv_nav_btn_left']/div")] private IWebElement toTheLeftButton;
        [FindsBy(How = How.ClassName, Using = "pv_counter")] private IWebElement photoCounter;

        public void AddToMyPhotos()
        {
            Match result = Regex.Match(photoCounter.Text, @"\d \D+ (\d+)");
            string countString = result.Groups.Cast<Group>().ToList().Select(x => x.Value).Skip(1).First();
            int count = int.Parse(countString);
            for (int i = 0; i < count; i++)
            {
                toTheRightButton.Click();
            }
        }
    }
}