using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product(int id, string name, BO.Jewelry category, double price, int quantity)
    {
        public int Barcode { get; init; } = id;
        public string ProductName { get; set; } = name;
        public BO.Jewelry Category { get; set; } = category;
        public double Price { get; set; } = price;
        public int Quantity { get; set; } = quantity;
        public List<SaleInProduct>? ListOfSales { get; set; } = [];
        
        public override string ToString() => this.ToStringProperty().ToString();
    }
}
