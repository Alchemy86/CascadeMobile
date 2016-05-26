using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace Mobile.CustomAttributes
{
    public class ValidationService : ActionFilterAttribute
    {
        private IConfiguration _config;
        public ValidationService(IConfiguration config)
        {
            _config = config;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;
            controller.ViewBag.Moop = "Meh";
            base.OnActionExecuting(context);
        }
    }
}
