using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.Models.Pages
{
    public class MyDetails : BaseModel
    {
        public MyDetails()
        {
            Details = new Dictionary<string, string>();
        }
        /// <summary>
        /// The Employee Description
        /// </summary>
        public string EmployeeDescription { get; set; }

        /// <summary>
        /// The details for this employee
        /// </summary>
        public Dictionary<string, string> Details { get; set; }
    }
}
