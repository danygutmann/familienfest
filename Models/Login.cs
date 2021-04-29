using System;
using System.ComponentModel.DataAnnotations;
namespace familienfest.Models
{
    public class Login
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Pass { get; set; }

        public bool StayLogin { get; set; }
    }
}
