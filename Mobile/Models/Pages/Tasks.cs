using System;
using System.Collections.Generic;

namespace Mobile.Models.Pages
{
    public class Tasks : BaseModel
    {
        public Tasks()
        {
            Items = new List<TaskModel>();
        }

        /// <summary>
        /// Check the items to see if we have values.
        /// </summary>
        public bool HasValues
        {
            get
            {
                return Items != null && (Items.Count > 0);
            }
        }

        /// <summary>
        /// Error Message
        /// </summary>
        public string NoTasksMessage { get; set; }

        /// <summary>
        /// MarkAsCompleteButtonVisible         
        /// </summary>
        public bool MarkAsCompleteButtonVisible { get; set; }

        /// <summary>
        /// TasksNavigationPanelVisible         
        /// </summary>
        public bool TasksNavigationPanelVisible { get; set; }

        /// <summary>
        /// TaskTypeCompletionMsgDivVisible
        /// </summary>
        public bool TaskTypeCompletionMessageDivVisible { get; set; }

        /// <summary>
        /// Whether or not this is the first page
        /// </summary>
        public bool IsFirstPage { get; set; }

        /// <summary>
        /// Whether or not this is the last page
        /// </summary>
        public bool IsLastPage { get; set; }

        /// <summary>
        /// How many pages are there
        /// </summary>
        public int NumberOfPages { get; set; }

        /// <summary>
        /// Collection of the Tasks
        /// </summary>
        public ICollection<TaskModel> Items { get; set; }

        /// <summary>
        /// Task Model
        /// </summary>
        public class TaskModel
        {
            /// <summary>
            /// Index ID - position starting from 1
            /// </summary>
            public int IndexID { get; set; }

            /// <summary>
            /// Task ID
            /// </summary>
            public Guid TaskID { get; set; }

            /// <summary>
            /// Task Name
            /// </summary>
            public string TaskName { get; set; }

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
        }
    }
}
