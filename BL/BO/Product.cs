using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public int _barcode = 0;
        public string _productName = "";
        public string? _category;
        public double _price;
        public int? _quantity;
        public static int index = 100000;

        public List<SaleInProduct> salesList = new List<SaleInProduct>();
    }
}
