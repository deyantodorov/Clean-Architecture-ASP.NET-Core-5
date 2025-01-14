﻿using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.Mvc.Models.User
{
    public class RegisterVm
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, type again!")]
        public string ConfirmPassword { get; set; }
    }
}
