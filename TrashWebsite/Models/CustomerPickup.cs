using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrashWebsite.Models
{
    public class CustomerPickup
    {
            [Key]
            public int PrimaryId { get; set; }

            [ForeignKey("Id")]
            public string TableId { get; set; }
            public virtual ApplicationUser Id { get; set; }

            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [Display(Name = "Address")]
            public string Address { get; set; }

            [Required]
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }

            [Display(Name = "Vacation Dates")]
            public string VacationDates { get; set; }

            [Required]
            [Display(Name = "Pick Up Day")]
            public string PickUpDay { get; set; }


    }
}