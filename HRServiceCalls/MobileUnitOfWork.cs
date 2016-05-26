using System;
using System.ServiceModel;
using HRServiceCalls.ApplicationService;
using HRServiceCalls.EmployeeDetailsService;
using HRServiceCalls.EmployeeGroupService;
using HRServiceCalls.HolidayService;
using HRServiceCalls.LoginService;
using HRServiceCalls.RequestService;
using HRServiceCalls.SecurityService;

namespace HRServiceCalls
{
    public class MobileUnitOfWork : IMobileUnitOfWork
    {
        /// <summary>
        /// WCF Services Root - Used to correct the end point of the services
        /// </summary>
        private string wcfServicesRoot;

        /// <summary>
        /// Replace Token - Used to correct the end point of the services
        /// </summary>
        private string replaceToken;

        private ApplicationServiceClient applicationService = null;
        private EmployeeDetailsServiceClient employeeDetailsService = null;
        private EmployeeGroupServiceClient employeeGroupService = null;
        private HolidayServiceClient holidayService = null;
        private LoginServiceClient loginService = null;

        /// <summary>
        /// Private Payroll Service
        /// </summary>
        //private PayrollServiceClient payrollService = null;

        private RequestServiceClient requestService = null;
        private SecurityServiceClient securityService = null;

        /// <summary>
        /// Private Task Service
        /// </summary>
        //private TaskServiceClient taskService = null;

        /// <summary>
        /// Private File Logger
        /// </summary>
        //private FileLogger fileLogger = null;

        public MobileUnitOfWork()
        {
        }

        public MobileUnitOfWork(string wcfServicesRoot, string replaceToken)
        {
            this.wcfServicesRoot = wcfServicesRoot;
            this.replaceToken = replaceToken;
            //fileLogger = new FileLogger();
        }
        public IApplicationService ApplicationService
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEmployeeDetailsService EmployeeDetailsService
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEmployeeGroupService EmployeeGroupService
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IHolidayService HolidayService
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ILoginService LoginService
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRequestService RequestService
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ISecurityService SecurityService
        {
            get
            {
                if (!CheckServiceOpen(securityService))
                {
                    securityService = new SecurityServiceClient();
                    securityService.Endpoint.Address = UpdateEndPointAddress(securityService.Endpoint.Address);
                }
                return securityService;
            }
        }

        /// <summary>
        /// Corrects the service endpoint
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        private EndpointAddress UpdateEndPointAddress(EndpointAddress original)
        {
            return new EndpointAddress(original.Uri.OriginalString.Replace(replaceToken, wcfServicesRoot));
        }

        /// <summary>
        /// Confirm the current service state
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        private bool CheckServiceOpen(object service)
        {
            if (service == null) return false;
            if (service is ICommunicationObject)
            {
                ICommunicationObject communicationObject = service as ICommunicationObject;

                if (communicationObject.State != CommunicationState.Opened)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
