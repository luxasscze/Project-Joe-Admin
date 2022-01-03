using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Created { get; set; }
        public string Customer { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryPostCode { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsActive { get; set; }
        public string Items { get; set; }
        public decimal DeliveryFee { get; set; }
        public string Status { get; set; }

    }
}
