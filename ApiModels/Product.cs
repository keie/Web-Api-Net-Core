

namespace ApiModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Product
    {
        public int Int { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public int IsDiscontinued { get; set; }
    }
}
