using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product(int _barcode, string? _productName, Jewelry _category, double _price, int _quantity)
    {
        public Product() : this(0, null, Jewelry.Braclate, 0.0, 0)
        {
        }

        public void toString()
        {
            Console.WriteLine($"barcode:{_barcode}, " +
                $"ProductName:{_productName}, Category:{_category}, " +
                $"Price:{_price}, Quantity:{_quantity}");
        }
    }
}
