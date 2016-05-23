using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace Mobile.CustomAttributes
{
    public class SiteSetting : ActionFilterAttribute
    {
        private IConfiguration _config;
        public SiteSetting(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Overwrite the procedure to pass in site settings by default for controllers
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;
            controller.ViewBag.SiteTitle = _config.GetSection("AppSettings").GetSection("Title2").Value;
            base.OnActionExecuting(context);
        }
    }
}
