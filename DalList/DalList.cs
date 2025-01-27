using Dal;
using DalApi;

namespace Dal
{
    internal sealed class DalList : IDAL
    {
        public ICustomer Customer => new CustomerImplementation();
        public IProduct Product => new ProductImplementation();
        public ISale Sale => new SaleImplementation();

        private static readonly DalList instance = new DalList();

        public static DalList Instance
        {
            get
            {
                return instance;
            }
        }

        private DalList() { }
    }
}
