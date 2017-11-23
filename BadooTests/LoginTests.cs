using BadooProject.Pages;
using NUnit.Framework;

namespace BadooTests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        protected RegisterPage RegisterPage => new RegisterPage();

        [Test]
        public void Login()
        {
            RegisterPage
                .GoToLoginPage()

                ;
        }
    }
}