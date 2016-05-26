using HRServiceCalls.ApplicationService;
using HRServiceCalls.EmployeeDetailsService;
using HRServiceCalls.EmployeeGroupService;
using HRServiceCalls.HolidayService;
using HRServiceCalls.LoginService;
using HRServiceCalls.RequestService;
using HRServiceCalls.SecurityService;

namespace HRServiceCalls
{
    public interface IMobileUnitOfWork
    {
        /// <summary>
        /// Application Service
        /// </summary>
        IApplicationService ApplicationService { get; }

        /// <summary>
        /// Employee Details Service
        /// </summary>
        IEmployeeDetailsService EmployeeDetailsService { get; }

        /// <summary>
        /// Employee Group Service
        /// </summary>
        IEmployeeGroupService EmployeeGroupService { get; }

        /// <summary>
        /// Holiday Service
        /// </summary>
        IHolidayService HolidayService { get; }

        /// <summary>
        /// Login Service
        /// </summary>
        ILoginService LoginService { get; }

        /// <summary>
        /// Payroll Service
        /// </summary>
        //IPayrollService PayrollService { get; }

        /// <summary>
        /// Request Service
        /// </summary>
        IRequestService RequestService { get; }

        /// <summary>
        /// Security Service
        /// </summary>
        ISecurityService SecurityService { get; }

        /// <summary>
        /// Task Service
        /// </summary>
        //ITaskService TaskService { get; }

        /// <summary>
        /// File Logger - Not a service
        /// </summary>
        //IFileLogger FileLogger { get; }
    }
}
