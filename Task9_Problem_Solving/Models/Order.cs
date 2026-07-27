using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task9_Problem_Solving.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }


        // Caontain M:N
        public List<ProductOrdered> ProductOrdered { get; set; }


        // have 1:1
        public Review Review { get; set; }
    }
}
