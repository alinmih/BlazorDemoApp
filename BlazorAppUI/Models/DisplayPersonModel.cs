using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppUI.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15,ErrorMessage ="First Name is to long.")]
        [MinLength(5,ErrorMessage ="First Name is to short.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Last Name is to long.")]
        [MinLength(5, ErrorMessage = "Last Name is to short.")]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
