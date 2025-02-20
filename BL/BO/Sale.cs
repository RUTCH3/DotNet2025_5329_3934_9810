using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int _saleId = 0;
        public int _productId = 0;
        public int? _amount;
        public double _salePrice;
        public bool _forAllCusts;
        public DateTime _startDate;
        public DateTime _endDate;

    }
}
