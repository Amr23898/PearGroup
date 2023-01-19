using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TaskPearGroup.ViewModel
{
    public class ProductVm
    {
        [HiddenInput]
        public int ProductId { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "الاسم يجب ان يكون حروف وليس ارقام")]
        public string ProductName { get; set; }
        [Required]
       [RegularExpression("[0-9]+(\\.[0-9]+)?$", ErrorMessage = "برجاء ادخال رقم صحيح او كسر")]
        public decimal QauantityPerUnit { get; set; }
        [Required]
        [RegularExpression("[0-9]+(\\.[0-9]+)?$", ErrorMessage = "برجاء ادخال رقم صحيح او كسر")]
        public decimal ReorderLevel { get; set; }
        [Required]
        [RegularExpression("[0-9]+(\\.[0-9]+)?$", ErrorMessage = "برجاء ادخال رقم صحيح او كسر")]
        public decimal UnitPrice { get; set; }
        [Required]
        [RegularExpression("[0-9]$", ErrorMessage = "برجاء ادخال رقم صحيح  ")]
        public int UnitsInStock { get; set; }
        [Required]
        [RegularExpression("[0-9]$", ErrorMessage = "برجاء ادخال رقم صحيح  ")]
        public int UnitsOnOrder { get; set; }
        public int? SupplierId { get; set; }
    }
}
