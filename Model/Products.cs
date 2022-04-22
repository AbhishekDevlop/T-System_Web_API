using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace T_System_Web_Api.Model
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
