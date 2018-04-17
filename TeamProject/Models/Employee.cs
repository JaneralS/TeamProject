using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamProject.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Required(ErrorMessage = "Required")]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Employee ID")]
        public string EmployeeID { get; set; } // primary key

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }


        // Observe that a Project will contain many Assignments.
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}