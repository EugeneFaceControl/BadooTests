using System.Configuration;

namespace BadooProject.Utils
{
    public class TestSettings
    {
        public string BaseURL { get; set; }
        public string BrowserName { get; set; }
        public double ExplicitTimeout { get; set; }
        public double ImplicitTimeout { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private string Get(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public TestSettings()
        {
            BaseURL = Get("baseURL");
            BrowserName = Get("browserName");
            ExplicitTimeout = double.Parse(Get("explicitTimeout"));
            ImplicitTimeout = double.Parse(Get("implicitTimeout"));
            Email = Get("email");
            Password = Get("password");
        }
    }
}