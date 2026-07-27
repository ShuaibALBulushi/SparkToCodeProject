using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task9_Problem_Solving.Models
{
    [PrimaryKey(nameof(ProductId), nameof(OrderId))]
    public class ProductOrdered
    {
        public int Quantity { get; set; }

        // containt M:N
        [ForeignKey("product")]
        public int ProductId { get; set; }
        public Product product { get; set; }


        [ForeignKey("order")]
        public int OrderId { get; set; }
        public Order order { get; set; }

    }
}
