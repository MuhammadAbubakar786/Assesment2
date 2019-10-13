using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assesment2.Models
{
    public partial class UsersManagement
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Please Enter UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter UserName")]
        public string DisplayName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public string ProfilePicture { get; set; }
        [Required(ErrorMessage = "Please Enter Date")]
        public string RegisteredData { get; set; }
    }
}
