using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task9_Problem_Solving.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string PublicName { get; set; }
        public double ProductPrice { get; set; }


        // Has 1:M
        [ForeignKey("category")]
        public int CategoryId { get; set; }
        public Category category { get; set; }


        // Caontain M:N
        public List<ProductOrdered> ProductOrdered { get; set; }
    }
}
