using Dal;
using DalApi;

namespace Dal
{
    public class DalListClass : IDAL
    {
        public ICustomer Customer => new CustomerImplementation();
        public IProduct Product => new ProductImplementation();
        public ISale Sale => new SaleImplementation();
    }
}
