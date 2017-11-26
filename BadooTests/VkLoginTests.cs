using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BadooProject.Pages.Vk;
using BadooProject.Utils;
using NUnit.Framework;

namespace BadooTests
{
    [TestFixture]
    public class VkLoginTests : BaseTest
    {
        protected WelcomePage WelcomePage => new WelcomePage();
        [Test]
        public void LoginVk()
        {
            Browser.Goto("https://vk.com/feed");

            WelcomePage
                .Login()
                .GoToAlbums()
                .GoToSavedPhotos()
                .AddToMyPhotos()
                ;
        }
    }
}
