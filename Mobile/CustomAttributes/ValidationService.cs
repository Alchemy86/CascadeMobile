using System;
using System.Threading;
using HRServiceCalls.LoginService;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Mobile.Models;

namespace Mobile.CustomAttributes
{
    public class ValidationService : ActionFilterAttribute
    {
        private IConfiguration _config;
        private SessionDetails _session;
        private ILoginService _loginService;
        private Controller _controller;
        public ValidationService(IConfiguration config, SessionDetails session)
        {
            _config = config;
            _session = session;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;
            _controller = controller;
            controller.ViewBag.Moop = "Meh";
            base.OnActionExecuting(context);

        }

        public void RedirectToLoginIfNoSession()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                if (_session.CascadeSessionToken == Guid.Empty || !_loginService.CheckSession(_session.CascadeSessionToken))
                {
                    RedirectToLogin();
                }
            }
            catch (ThreadAbortException)
            {
                //Response.Redirect throws a ThreadAbortException so a check is needed to ensure that if the 
                //previous Response.Redirect is called, then there is no need to log the exception.
            }
            catch (Exception ex)
            {
                //LogError(System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginService.CheckSession", ex);
                RedirectToLogin();
            }
            finally
            {
                //ServiceCleanUp(Context.LoginService, "HolidayService.GetEmployeeBalanceForRequest");
            }
        }

        private void RedirectToLogin()
        {
            _controller.RedirectToAction("Login");
        }

    }
}
