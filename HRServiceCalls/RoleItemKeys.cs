using System.Collections.Generic;

namespace HRServiceCalls
{
    public class RoleItemKeys : List<string>
    {
        /// <summary>
        /// Role Item Keys Constructor
        /// </summary>
        public RoleItemKeys()
        {
            this.Add(RoleItemKey.MOBILE_MYDETAILS_PAGE);
            this.Add(RoleItemKey.MOBILE_HEADCOUNTSTATUS_PAGE);
            this.Add(RoleItemKey.MOBILE_MYHOLIDAYS_PAGE);
            this.Add(RoleItemKey.MOBILE_MYPAYSLIP_PAGE);
            this.Add(RoleItemKey.MOBILE_MYTASKS_PAGE);
            this.Add(RoleItemKey.MOBILE_HOLIDAYAUTHORISATIONS_PAGE);
            this.Add(RoleItemKey.MOBILE_BOOKHOLIDAY_PAGE);
            this.Add(RoleItemKey.MOBILE_CANCELHOLIDAY_PAGE);
            this.Add(RoleItemKey.MOBILE_EMPLOYEESFORATTENDANCESTATUS_PAGE);
            this.Add(RoleItemKey.MOBILE_HOLIDAYREQUESTDETAILS_PAGE);
            this.Add(RoleItemKey.MOBILE_HOME_PAGE);
            this.Add(RoleItemKey.MOBILE_TASKDETAILS_PAGE);
        }
    }
}
