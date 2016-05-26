using System;
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
                throw new NotImplementedException();
            }
        }
    }
}
