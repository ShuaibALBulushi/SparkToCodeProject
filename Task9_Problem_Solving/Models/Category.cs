using System;
using System.Collections.Generic;
using System.Text;

namespace Task9_Problem_Solving.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


        // Has 1:1
        public Product product { get; set; }
    }
}
