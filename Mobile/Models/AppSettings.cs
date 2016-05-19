using Microsoft.Extensions.Configuration;

namespace Mobile.Models
{
    public class AppSettings : IAppSettings
    {
        private IConfiguration _config;
        public AppSettings(IConfiguration config)
        {
            SiteTitle = _config.GetSection("AppSettings").GetSection("Title").Value;
        }

        public string SiteTitle { get; set; }

    }
}
