using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Mobile.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected Models.AppSettings _appSettings;
        private IConfiguration _config;
        public ControllerBase(IConfiguration config)
        {
            _config = config;
            _appSettings = new Models.AppSettings();
            _appSettings.SiteTitle = _config.GetSection("AppSettings").GetSection("Title").Value;

            ViewBag.Settings = _appSettings;
        }
    }
}
