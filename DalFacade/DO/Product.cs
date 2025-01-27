using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product
    {
        private int _barcode = 0;
        private string _productName = "";
        private string? _category;
        private double _price;
        private int? _quantity;
        private static int index = 100000;

        public int Barcode { get => _barcode; set => _barcode = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public string? Category { get => _category; set => _category = value; }
        public double Price { get => _price; set => _price = value; }
        public int? Quantity { get => _quantity; set => _quantity = value; }
        public Product() { }
        public Product(string productName, string? category, double price, int? quantity)
        {
            this._barcode = index++;
            this._productName = productName;
            this._category = category;
            this._price = price;
            this._quantity = quantity;
        }
        public void toString()
        {
            Console.WriteLine($"barcode:{_barcode}, " +
                $"ProductName:{_productName}, Category:{_category}, " +
                $"Price:{_price}, Quantity:{_quantity}");
        }
    }
}
