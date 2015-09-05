using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TheStillHeron.Models
{
    public class ContactViewModel
    {
        [Display(Name = "Email")]
        [Required]
        public string EmailAddress{get; set;}

        [Display(Name = "LinkedIn")]
        public string LinkedInUrl { get; set; }
    }
}