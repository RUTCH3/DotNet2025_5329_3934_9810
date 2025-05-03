using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int productId { get; set; }
        public string productName { get; set; } = string.Empty;
        public double basePrice { get; set; }
        public int amount { get; set; }
        public List<Sale> salesList { get; set; }
        public double finalPrice { get; set; }

        public ProductInOrder() { }
    }
}
