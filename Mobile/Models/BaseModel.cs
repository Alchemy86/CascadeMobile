using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.Models
{
    /// <summary>
    /// Base Model used for all models in our pages
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// Flag to indicate if the service was successfully contacted, and data loaded.
        /// </summary>
        public bool ServiceSuccess { get; set; }

        /// <summary>
        /// Used to show an informational message displayed AS WELL as the model.
        /// </summary>
        public string InfomationMessage { get; set; }

        /// <summary>
        /// The message to show as an error. Used in conjunction with ServiceSuccess.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
