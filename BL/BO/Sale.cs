using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        private int _saleId = 0;
        private int _productId = 0;
        private int? _amount;
        private double _salePrice;
        private bool _forAllCusts;
        private DateTime _startDate;
        private DateTime _endDate;

        public int SaleId { get => _saleId; set => _saleId = value; }
        public int ProductId { get => _productId; set => _productId = value; }
        public int? Amount { get => _amount; set => _amount = value; }
        public double SalePrice { get => _salePrice; set => _salePrice = value; }
        public bool ForAllCusts { get => _forAllCusts; set => _forAllCusts = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }

        public Sale() { }
        public Sale(int saleId, int productId, int? amount, double salePrice, bool forAllCusts, DateTime startDate, DateTime endDate)
        {
            this._saleId = saleId;
            this._productId = productId;
            this._amount = amount;
            this._salePrice = salePrice;
            this._forAllCusts = forAllCusts;
            this._startDate = startDate;
            this._endDate = endDate;
        }
        public void toString()
        {
            Console.WriteLine($"sale id: {_saleId}, product id: {_productId}, amount: {_salePrice}, " +
                $"for all custs: {_forAllCusts}, start date: {_startDate}, end date: {_endDate}");
        }
    }
}
