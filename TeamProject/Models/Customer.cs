using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TeamProject.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Required(ErrorMessage = "Required")]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Customer ID")]
        public string CustomerID { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Customer Address")]
        public string CustomerAddress { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Customer Phone Number")]
        public string CustomerPhone { get; set; }
        public virtual ICollection<RequestList> RequestList { set; get; }

    }
}