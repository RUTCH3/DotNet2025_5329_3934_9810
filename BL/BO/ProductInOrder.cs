using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder(int ProductId, string? ProductName, double BasePriceToProduct, int CountInOrder, List<SaleInProduct>? LIstProductSales, double FinalPrice)
    {
        public int ProductId { get; set; } = ProductId;
        public string ProductName { get; set; } = ProductName;
        public double BasePrice { get; set; } = BasePriceToProduct;
        public int Amount { get; set; } = CountInOrder;
        public List<SaleInProduct> SalesList { get; set; } = LIstProductSales;
        public double FinalPrice { get; set; } = FinalPrice;

        public override string ToString() => this.ToStringProperty();

    }
}
