namespace Dal;
using DO;
static internal class DataSource1
{
    internal static class DataSource
    {
        internal static List<Customer>? Customers = new List<Customer>();
        internal static List<Product>? Products = new List<Product>();
        internal static List<Sale>? Sales = new List<Sale>();

        internal static class Config
        {
            internal const int runNumId = 0;
            private static int runNum = runNumId;
            private static int RunNum { get => runNum++; }
        }
    }
}
