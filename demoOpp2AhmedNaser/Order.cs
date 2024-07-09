using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOpp2AhmedNasr
{
    internal class Order
    {
        public int Id { get; set; }
        public string BuyerEmail { get; set; }
        public decimal SubTotal { get; set;}
        public OrderItem[] Items { get; set; }

        public Order(string userEmail , OrderItem[] items )
        {
                BuyerEmail = userEmail;
                Items      = items ;
        }
    }
}
