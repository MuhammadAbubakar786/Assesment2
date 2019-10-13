using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assesment2.Models
{
    public partial class CategoriesManagement
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter UserName")]
        public string Name { get; set; }
        public string Picture { get; set; }
        [Required(ErrorMessage = "Please Enter Status")]
        public string Status { get; set; }
    }
}
