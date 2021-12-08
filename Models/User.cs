using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;


namespace Login.Models
{
    public class User : IdentityUser
    {
        [StringLength(50)]
        [PersonalData]
        public string Name { get; set; }


        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(25)]
        public string Password { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }

    }
}
