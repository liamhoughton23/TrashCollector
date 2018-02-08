using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashWebsite.Models
{
    public class CustomerPickup
    {


            [Key]
            public int PrimaryId { get; set; }
            
            public string Id { get; set; }

            [ForeignKey("Id")]
            public ApplicationUser TableId { get; set; }

            [Required]
            [Display(Name = "Address")]
            public string Address { get; set; }
            
            [Required]
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }

            [Required]
            [Display(Name = "Vacation Day")]
            public string VacationDates { get; set; }

            [Required]
            [Display(Name = "Pick Up Day")]
            public string PickUpDay { get; set; }
    }
}