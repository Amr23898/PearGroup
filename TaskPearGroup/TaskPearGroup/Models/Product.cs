using System;
using System.Collections.Generic;

namespace TaskPearGroup.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? QauantityPerUnit { get; set; }
        public decimal? ReorderLevel { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? SupplierId { get; set; }

        public virtual Supplier? Supplier { get; set; }
    }
}
