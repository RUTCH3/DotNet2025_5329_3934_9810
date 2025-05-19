using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale(int _saleId, int _productId, int _salePrice, double _totalPrice, bool _forAllCusts, DateTime _startDate, DateTime _endDate)
    {
        public Sale() : this(0, 0, 0, 0.0, false, new DateTime(), new DateTime())
        {
        }

        public override string ToString()
        {
            return $"sale id: {_saleId}, product id: {_productId}, amount: {_salePrice}, total price: {_totalPrice}" +
                $"for all custs: {_forAllCusts}, start date: {_startDate}, end date: {_endDate}");
        }
    }
}
