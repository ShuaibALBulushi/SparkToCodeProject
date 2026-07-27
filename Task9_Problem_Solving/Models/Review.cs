using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task9_Problem_Solving.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }


        // have 1:1
        [ForeignKey("order")]
        public int OrderId { get; set; }
        public Order order { get; set; }
    }
}
