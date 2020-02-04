
namespace ApiModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OrderItem
    {
        public int Int { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
    }
}
