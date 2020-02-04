
namespace ApiModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Order
    {
        public int Int { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
