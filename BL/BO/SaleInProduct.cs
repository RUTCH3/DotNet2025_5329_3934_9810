using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct(int SaleId, int amountToSale, double price, bool IsAllCustomers)
    {
        public int SaleId { get; } = SaleId;
        public int AmountToSale { get; set; } = amountToSale;
        public double Price { get; set; } = price;
        public bool IsAllCustomers { get; set; } = IsAllCustomers;
        public override string ToString() => this.ToStringProperty();
    }
}
