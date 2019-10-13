using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assesment2.Models
{
    public partial class ItemManagement
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter CategoryID")]
        public string CategorieId { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Write Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please set Quantity")]
        public int? Quantity { get; set; }
        [Required(ErrorMessage = "Please set Price")]
        public int? CostPrice { get; set; }
        [Required(ErrorMessage = "Please set salePrice")]
        public int? SalePrice { get; set; }
        public string MainImage { get; set; }
        [Required(ErrorMessage = "Please Enter ItemCode")]
        public int? ItemCode { get; set; }
        public string MainColor { get; set; }
        [Required(ErrorMessage = "Please Enter Status")]
        public string Status { get; set; }
    }
}
