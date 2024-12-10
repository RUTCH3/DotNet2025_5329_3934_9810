using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDAL
    {
        public ICustomer iCustomer { get; }
        public IProduct iProduct { get; }
        public ISale iSale { get; }
    }
}
