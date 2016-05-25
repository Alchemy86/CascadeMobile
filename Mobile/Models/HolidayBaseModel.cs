using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.Models
{
    public class HolidayBaseModel
    {
        //public Cascade.HR.BLL.DataContracts.PageAccessLevelType UserAccessLevel { get; set; }

        /// <summary>
        /// User can delete their holidays
        /// </summary>
        public bool UserCanDelete { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Request
        /// </summary>
        public RequestModel Request { get; set; }

        /// <summary>
        /// Child Request
        /// </summary>
        public RequestModel ChildRequest { get; set; }

        /// <summary>
        /// The Ruid for the object
        /// </summary>
        public Guid Ruid { get; set; }

        /// <summary>
        /// Start Date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End Date
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Duration Day Part
        /// </summary>
        //public AttendanceDayPart DurationDayPart { get; set; }
    }

    /// <summary>
    /// Model of a request
    /// </summary>
    public class RequestModel
    {
        /// <summary>
        /// RequestID
        /// </summary>
        public Guid RequestID { get; set; }

        /// <summary>
        /// UpdateType
        /// </summary>
        public string UpdateType { get; set; }

        /// <summary>
        /// RequestType
        /// </summary>
        public string RequestType { get; set; }

        /// <summary>
        /// RequestDetails
        /// </summary>
        public object RequestDetails { get; set; }
    }
}
