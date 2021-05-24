using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExampleWebApp.Models
{
    public class ProductBindingTarget
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public long CategoryId { get; set; }
        [Required]
        public long SupplierId { get; set; }

        public Product ToProduct() => new Product()
        {
            Name = this.Name,
            Price = this.Price,
            CategoryId = this.CategoryId,
            SupplierId = this.SupplierId
        };
    }
}
