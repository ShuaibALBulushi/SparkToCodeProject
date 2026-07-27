using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task9_Problem_Solving.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string PublicName { get; set; }
        public double ProductPrice { get; set; }


        // Has 1:1
        [ForeignKey("category")]
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
