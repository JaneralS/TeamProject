using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamProject.Models
{
    public class Ticket
    {
        [Key]
        public int TicketsId { get; set; } // This column will be the auto-generated primary key.

        [Required(ErrorMessage = "RequestID required")]
        public string RequestListingId { get; set; } // in case of database this would be the foreign key

        [Required(ErrorMessage = "EmployeeID required")]
        public string EmployeeId { get; set; } // in case of database this would be the foreign key

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Date required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateAssigned { get; set; }

        [Required(ErrorMessage = "Description required")]
        [StringLength(30, MinimumLength = 4)]
        public string Description { get; set; }

        // Observe that an Assignment will be associated to a project and 
        // it will also be associated to an employee

        public virtual RequestList RequestList { get; set; }
        public virtual Employee Employee { get; set; }
    }
}