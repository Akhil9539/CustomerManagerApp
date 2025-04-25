using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagerApp.Models
{
    public class Customer
    {
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Range(0, 110)]
    public int Age { get; set; }

    [Required]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d\s]+$", ErrorMessage = "Post code must contain letters and numbers, spaces allowed.")]
    public string PostCode { get; set; }

    [Range(0, 2.5)]
    [Display(Name = "Height (meters)")]
    public double Height { get; set; }
    
    }
}