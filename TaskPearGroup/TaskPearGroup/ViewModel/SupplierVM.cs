using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TaskPearGroup.ViewModel
{
    public class SupplierVM
    {
        [HiddenInput]
        public int SupplierId { get; set; }
        [Required(ErrorMessage ="Suppliers Name Is Required")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Name Must Character")]
        [MaxLength(50,ErrorMessage ="name must bot more than 60 character")]
        public string? SupplierName { get; set; }
    }
}
