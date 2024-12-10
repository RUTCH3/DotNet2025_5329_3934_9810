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
            Customer customer = new Customer(328187985, "Reut", "Shderot 8", "0578211450");
            s_dal?.Customer?.Create(customer);
        }
        private static void createProduct()
        {
            Product product = new Product(2, "DisneyPajamas", Catagories.Pajamas, 120, 52);
            s_dal?.Product?.Create(product);
        }
        private static void createSale()
        {
            Sale sale = new Sale(22, 1, 2, true, 100, new DateTime(2024, 11, 20), new DateTime(2024, 12, 10)));
            s_dal?.Sale?.Create(sale);
        }
        public static void Initialize(IDAL dal)
        {
            s_dal = dal;

            createCustomer();
            createProduct();
            createSale();
        }

    }
}
