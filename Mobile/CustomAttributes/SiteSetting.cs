using System.Configuration;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Filters;
using Mobile.Models;

namespace Mobile.CustomAttributes
{
    public class SiteSetting : ActionFilterAttribute
    {
        //private IAppSettings _settings;
        //public SiteSetting(IAppSettings settings)
        //{
        //    _settings = settings;
        //}

        /// <summary>
        /// Overwrite the procedure to pass in site settings by default for controllers
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //var logger = context.Request.GetDependencyScope().GetService(typeof(IAppSettings)) as IAppSettings;
            var controller = context.Controller as Controller;
            //controller.ViewBag.SiteTitle = "Moose";//ConfigurationManager.AppSettings["CascadeHrEndPointRoot"].ToString();
            base.OnActionExecuting(context);
        }
    }
}
