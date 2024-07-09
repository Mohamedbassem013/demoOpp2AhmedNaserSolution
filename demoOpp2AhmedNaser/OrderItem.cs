using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOpp2AhmedNasr
{
    internal class OrderItem
    {
        public int Id { get; set; }

        public string Name { get; set; } = default;
        public Product product { get; set; } = default;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Product Product)
        {
            product = Product;
        }
    }
}
