using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.Models.Pages
{
    public class BookHolidayModel : BaseModel
    {
        /// <summary>
        /// Holiday Balance object
        /// </summary>
        public HolidayBalanceModel HolidayBalance { get; set; }

        /// <summary>
        /// Single Holiday
        /// </summary>
        public SingleHolidayModel SingleHoliday { get; set; }
    }

    /// <summary>
    /// Holiday Balance Model
    /// </summary>
    public class HolidayBalanceModel : BaseModel
    {
        /// <summary>
        /// Invalid Balance Details
        /// </summary>
        public bool InvalidBalanceDetails { get; set; }

        /// <summary>
        /// Taken Preview
        /// </summary>
        public string TakenPreview { get; set; }

        /// <summary>
        /// Remaining Preview
        /// </summary>
        public string RemainingPreview { get; set; }

        /// <summary>
        /// Holiday Balance Taken:
        /// BasePage.GetDurationDescription(_holidayBalance.Taken, _holidayBalance.Units)
        /// </summary>
        public string BalanceTaken { get; set; }

        /// <summary>
        /// BalanceRemaining
        /// decimal remainingBalance = _holidayBalance.Entitlement - _holidayBalance.Taken;
        /// BasePage.GetDurationDescription(remainingBalance, _holidayBalance.Units)
        /// </summary>
        public string BalanceRemainingBefore { get; set; }

        /// <summary>
        /// ERROR - Could not fix this on initial load
        /// BalanceRemainingAfter
        /// decimal remainingBalance = _holidayBalance.Entitlement - _holidayBalance.Taken;
        /// BasePage.GetDurationDescription(remainingBalance - _CurrentRequest.Duration, _holidayBalance.Units
        /// </summary>
        public string BalanceRemainingAfter { get; set; }

        /// <summary>
        /// ERROR - Could not fix this on initial load
        /// The Cost of this request:
        /// BasePage.GetDurationDescription(_CurrentRequest.Duration, _CurrentRequest.Units);
        /// </summary>
        public string ThisRequestCost { get; set; }

        /// <summary>
        /// Entitlement Description
        /// </summary>
        public decimal Entitlement { get; set; }

        /// <summary>
        /// BasePage.GetDurationDescription(_holidayBalance.Entitlement, _holidayBalance.Units)
        /// </summary>
        public string EntitlementDescription { get; set; }

        #region DataContract Properties, remove any not used.
        /// <summary>
        /// Entitlement year start.
        /// </summary>
        public DateTime EntitlementYearStart { get; set; }

        /// <summary>
        /// EntitlementYearEnd
        /// </summary>
        public DateTime EntitlementYearEnd { get; set; }

        /// <summary>
        /// Taken
        /// </summary>
        public decimal Taken { get; set; }

        /// <summary>
        /// Units
        /// </summary>
        public AttendanceUnit Units { get; set; }
        #endregion
    }

    /// <summary>
    /// Single Holiday Model 
    /// </summary>
    public class MultipleHolidayModel
    {
    }

    /// <summary>
    /// Single Holiday Model 
    /// </summary>
    public class SingleHolidayModel
    {
        /// <summary>
        /// SingleHoliday Holiday
        /// </summary>
        public HolidayModel Holiday { get; set; }
    }

    /// <summary>
    /// The holiday Base model
    /// </summary>
    public class HolidayModel : HolidayBaseModel
    {
        /// <summary>
        /// BasePage.GetDurationDescription(_CurrentRequest.Duration, _CurrentRequest.Units); 
        /// </summary>
        public string RequestCost { get; set; }

        /// <summary>
        /// Duration of the Holiday
        /// </summary>
        public decimal Duration { get; set; }
    }
}
