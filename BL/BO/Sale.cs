using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale(int _saleId, int _productId, int _amount, double _salePrice, bool _forAllCusts, DateTime _startDate, DateTime _endDate)
    {
        public int SaleId { get; init; } = _saleId;
        public int ProductId { get; set; } = _productId;
        public int Amount { get; set; }= _amount;
        public double SalePrice { get; set; } = _salePrice;
        public bool ForAllCusts { get; set; } = _forAllCusts;
        public DateTime StartDate { get; set; } = _startDate;
        public DateTime EndDate { get; set; } = _endDate;

        public override string ToString()=>this.ToStringProperty().ToString();
    }
}
