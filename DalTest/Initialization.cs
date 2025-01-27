using DO;
using DalApi;
using DalList;

namespace DalTest
{
    public static class Initialization
    {
        private static IDAL? s_dal { get; set; }
        //private static ICustomer? s_dalCustomer { get; set; }
        //private static IProduct? s_dalProduct { get; set; }
        //private static ISale? s_dalSale { get; set; }

        private static void createCustomer()
        {
            Customer customer = new Customer();
            s_dal?.Customer?.Create(customer);
        }
        private static void createProduct()
        {
            Product product = new Product();
            s_dal?.Product?.Create(product);
        }
        private static void createSale()
        {
            Sale sale = new Sale();
            s_dal?.Sale?.Create(sale);
        }
        public static void Initialize()
        {
            s_dal = DalApi.Factory.Get;
        }

    }
}
