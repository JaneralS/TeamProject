using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Web;

namespace TeamProject.Models
{
    public class RequestList
    {
        
        [Required(ErrorMessage = "Required")]
        [Key]
        public int RequestId { get; set; } // This column will be the auto-generated primary key.

        [Required(ErrorMessage = "Required")]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Customer ID")]
        public string CustomerID { get; set; } // in case of database this would be the foreign key

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Brand")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Model")]
        public string Model { get; set; }

        

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Date required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ReceivedDate { get; set; }

        

        public virtual Customer Customer { get; set; } // this is known as Navigation property 
        // Observe that an employee may have many assignments
        public virtual ICollection<Ticket> Ticket { get; set; }

    }
}
