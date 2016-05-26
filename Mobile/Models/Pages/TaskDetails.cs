using System;

namespace Mobile.Models.Pages
{
    public class TaskDetails : BaseModel
    {
        /// <summary>
        /// Task ID
        /// </summary>
        public Guid TaskID { get; set; }

        /// <summary>
        /// Task Name
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// Task Status
        /// </summary>
        public string TaskStatus { get; set; }

        /// <summary>
        /// Task Type
        /// </summary>
        //public TaskType TaskType { get; set; }

        /// <summary>
        /// description of the employee to which this task relates to
        /// </summary>
        public string RelatesToEmployeeDescription { get; set; }

        /// <summary>
        /// description of the employee to which this task belongs
        /// </summary>
        public string OwnerEmployeeDescription { get; set; }

        /// <summary>
        ///  A description of the due date
        /// </summary>
        public string DueDateDescription { get; set; }

        /// <summary>
        /// A description of the task type as a string value
        /// </summary>
        public string TaskTypeStringValue { get; set; }

        /// <summary>
        /// More Information about the task
        /// </summary>
        public string MoreInfo { get; set; }

        /// <summary>
        /// Whether or not this is the first task
        /// </summary>
        public bool IsFirstTask { get; set; }

        /// <summary>
        /// Whether or not this is the last task
        /// </summary>
        public bool IsLastTask { get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// How many pages are there
        /// </summary>
        public int NumberOfPages { get; set; }

        /// <summary>
        /// MarkAsCompleteButtonVisible         
        /// </summary>
        public bool MarkAsCompleteButtonVisible { get; set; }
    }

}
