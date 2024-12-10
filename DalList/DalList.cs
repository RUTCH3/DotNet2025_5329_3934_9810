using Dal;
using DalApi;

namespace Dal
{
    public class DalList : IDAL
    {
        public ICustomer iCustomer => new CustomerImplementation();
        public IProduct iProduct => new ProductImplementation();
        public ISale iSale => new SaleImplementation();
    }
}
