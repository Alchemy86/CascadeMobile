using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.Models.Pages
{
    public class MyTeam : BaseModel
    {
        /// <summary>
        /// The total number of employees across all teams.
        /// </summary>
        public int TotalEmployees { get; set; }

        /// <summary>
        /// MyTeamModel Items
        /// </summary>
        public List<MyTeamModelItem> Items { get; set; }

        /// <summary>
        /// The name of the group which has been retrieved
        /// </summary>
        public string TeamName { get; set; }
    }

    public class MyTeamModelItem
    {
        /// <summary>
        /// Constructor for the my team model
        /// </summary>
        /// <param name="count"></param>
        /// <param name="description"></param>
        public MyTeamModelItem(int count, string description)
        {
            Count = count;
            Description = description;
        }

        /// <summary>
        /// The description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Count
        /// </summary>
        public int Count { get; set; }
    }
}
