using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashWebsite.Models
{
    public class EmployeeModel
    {
            [Key]
            public int Id { get; set; }

            [Required]
            [Display(Name = "Zip Code Route")]
            public string ZipCode { get; set; }

    }
}