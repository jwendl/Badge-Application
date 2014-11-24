using Magenic.BadgeApplication.Common.Interfaces;
using Magenic.BadgeApplication.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Magenic.BadgeApplication.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class MultipleActivityViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleActivityViewModel" /> class.
        /// </summary>
        public MultipleActivityViewModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleActivityViewModel" /> class.
        /// </summary>
        /// <param name="allActivities">All activities.</param>
        /// <param name="allEmployees">All employees.</param>
        public MultipleActivityViewModel(IActivityCollection allActivities, IUserCollection allEmployees)
        {
            ActivitySubmissionDate = DateTime.Now.Date;
            AllActivities = new SelectList(allActivities, "Id", "Name");
            AllEmployees = new MultiSelectList(allEmployees, "EmployeeId", "FullName");
        }

        /// <summary>
        /// Gets or sets all activities.
        /// </summary>
        /// <value>
        /// All activities.
        /// </value>
        public SelectList AllActivities { get; private set; }

        /// <summary>
        /// Gets or sets the selected activity ids.
        /// </summary>
        /// <value>
        /// The selected activity ids.
        /// </value>
        //public List<int> SelectedActivityIds { get; set; }
        public int SelectedActivityId { get; set; }

        /// <summary>
        /// Gets or sets all users.
        /// </summary>
        /// <value>
        /// All users.
        /// </value>
        public MultiSelectList AllEmployees { get; private set; }

        /// <summary>
        /// Gets or sets the selected users.
        /// </summary>
        /// <value>
        /// The selected users.
        /// </value>
        public IEnumerable<int> SelectedEmployeeIds { get; set; }

        /// <summary>
        /// The date the activity occurred, should be set and saved in UTC.
        /// </summary>
        [Display(Name = "ActivitySubmissionDateLabel", ResourceType = typeof(ApplicationResources))]
        public DateTime ActivitySubmissionDate { get; set; }

        /// <summary>
        /// Any notes associated with this submission.
        /// </summary>
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}