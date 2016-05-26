using System;
using System.Collections.Generic;
using System.Threading;
using HRServiceCalls;
using HRServiceCalls.SecurityService;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Filters;
using Microsoft.AspNet.Routing;
using Microsoft.Extensions.Configuration;
using Mobile.Models;

namespace Mobile.CustomAttributes
{
    public class ValidationService : ActionFilterAttribute
    {
        private IConfiguration _config;
        private SessionDetails _session;
        private IMobileUnitOfWork _services;
        private Controller _controller;
        private ActionExecutingContext _context;

        /// <summary>
        /// Default unexpected error message.
        /// </summary>
        protected const string UNEXPECTED_ERROR_MSG = "An undefined error occurred. This may be due to a network problem or loss of connectivity. Please try again.";
        public ValidationService(IConfiguration config, IMobileUnitOfWork unitOfWork, SessionDetails session)
        {
            _config = config;
            _session = session;
            _services = unitOfWork;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;
            _context = context;
            _controller = controller;

            _controller.ViewBag.warning = "Login is required";

            
            base.OnActionExecuting(context);
            Validate(RoleItemKey.MOBILE_TASKDETAILS_PAGE);

        }

        /// <summary>
        /// All role items pertaining to the mobile project
        /// </summary>
        public List<string> AllRoleItems
        {
            get
            {
                //TODO: Create a separate array for the icons?
                return new RoleItemKeys();
            }
        }

        /// <summary>
        /// Validate the user access to the page
        /// </summary>
        /// <param name="roleItemForPage"></param>
        public virtual Dictionary<string, bool> Validate(string roleItemKey)
        {
            RedirectToLoginIfNoSession();

            string output;
            Dictionary<string, bool> roleItems = GetRoleItemPermissions(AllRoleItems, out output);

            if (!UserHasRoleItem(roleItems, roleItemKey))
                RedirectToNoPermission();

            //if (!string.IsNullOrEmpty(output))
            //    baseView.ShowError(output);

            //baseView.ShowMenu(roleItems);

            return roleItems;
        }

        /// <summary>
        /// Determines if the supplied roleItemKey is true in the supplied roleItemPermissions dictionary.
        /// </summary>
        /// <param name="roleItemPermissions">This should have been populated by calling the GetRoleItemPermissions method.</param>
        /// <param name="roleItemKey">The RoleItemKey to check</param>
        /// <returns></returns>
        public bool UserHasRoleItem(Dictionary<string, bool> roleItemPermissions, string roleItemKey)
        {
            if (roleItemPermissions.Count > 0 && roleItemPermissions.ContainsKey(roleItemKey))
            {
                return roleItemPermissions[roleItemKey];
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Calls the WCF service to determine which role items the current logged in user
        /// has permission to access.
        /// </summary>
        /// <param name="roleItemsToCheck">An array of RoleItemKeys to check permission for.</param>
        /// <param name="errorMsgLiteral">If null and outcome isn't "Success", an error will be written to the Application Event Log.</param>
        /// <returns></returns>
        public Dictionary<string, bool> GetRoleItemPermissions(List<string> roleItemsToCheck, out string errorMsg)
        {
            Dictionary<string, bool> roleItemsWithFlags = new Dictionary<string, bool>();
            RoleItems roleItems = new RoleItems();
            errorMsg = "";

            try
            {
                roleItems = _services.SecurityService.GetRoleItemPermissions(_session.CascadeSessionToken, roleItemsToCheck.ToArray());
                OperationOutcomeStatus outcome = roleItems.OutcomeDetails.Status;
                switch (outcome)
                {
                    case OperationOutcomeStatus.Success:
                        roleItemsWithFlags = roleItems.Items;
                        break;
                    case OperationOutcomeStatus.Failure:
                        errorMsg = roleItems.OutcomeDetails.Description;
                        break;
                    case OperationOutcomeStatus.SystemException:
                        errorMsg = UNEXPECTED_ERROR_MSG;
                        break;
                }
            }
            catch (Exception ex)
            {
                //errorMsg = LogError(MethodInfo.GetCurrentMethod().Name, "Security.GetRoleItemPermissions", ex);
            }
            finally
            {
                //ServiceCleanUp(Context.SecurityService, "Security.GetRoleItemPermissions");
            }
            return roleItemsWithFlags;
        }

        public void RedirectToLoginIfNoSession()
        {
            try
            {
                if (_session.CascadeSessionToken == Guid.Empty || !_services.LoginService.CheckSession(_session.CascadeSessionToken))
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

        /// <summary>
        /// Redirect to the login page
        /// </summary>
        private void RedirectToLogin()
        {

            _context.Result = res();
        }

        private IActionResult res()
        {
            _controller.ViewBag.warning = "Suck it";
            return _controller.View("Login");
        }

        /// <summary>
        /// Redirect To No Permission Page
        /// </summary>
        public void RedirectToNoPermission()
        {
            _controller.RedirectToAction("Login");
        }

    }
}
