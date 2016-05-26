using System.Collections.Generic;

namespace Mobile.Models.Pages
{
    public class Home : BaseModel
    {
        /// <summary>
        /// My Record Button is Visible
        /// </summary>
        public bool MyRecordButtonVisible { get; set; }

        /// <summary>
        /// My Team Button is Visible
        /// </summary>
        public bool MyTeamButton { get; set; }

        /// <summary>
        /// My Holiday Button is Visible
        /// </summary>
        public bool HolidaysButton { get; set; }

        public bool PayslipButton { get; set; }

        public bool TasksButton { get; set; }

        public bool AuthoriseButton { get; set; }

        /// <summary>
        /// Notifications
        /// </summary>
        public Dictionary<string, int> Notifications { get; set; }
    }
}
