using BadooProject.Pages.Badoo;
using BadooProject.Utils;
using NUnit.Framework;

namespace BadooTests
{
    [TestFixture]
    public class BadooLoginTests : BaseTest
    {
        protected RegisterPage RegisterPage => new RegisterPage();

        [Test]
        public void LoginBadoo()
        {
            Browser.Goto(settings.BaseURL);
            RegisterPage
                .GoToLoginPage()
                .LoginViaFacebook()
                .Register()
                .LikePages()
                ;
        }

        [Test]
        public void JsExample()
        {
            Browser.Goto(settings.BaseURL);
            RegisterPage
                .GoToLoginPage()
                .LoginViaFacebook()
                .Register()
                .ExecuteJs()
                ;

        }
    }
}