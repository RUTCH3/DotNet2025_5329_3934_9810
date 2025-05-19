using DO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static class Tools
    {
        public static BO.Customer CastCustomerFromDOToBO(this DO.Customer c) => new(c._id, c._name, c._address, c._phone);

        public static DO.Customer CastCustomerFromBOToDO(this BO.Customer c) => new(c.Id, c.Name, c.Address!, c.Phone!);

        public static BO.Product CastProductFromDOToBO(this DO.Product p) => new(p._barcode, p._productName!, (BO.Jewelry)p._category, p._price, p._quantity);

        public static DO.Product CastProductFromBOToDO(this BO.Product p) => new(p.Barcode, p.ProductName, (DO.Jewelry)p.Category, p.Price, p.Quantity);

        public static BO.Sale CastSaleFromDOToBO(this DO.Sale s) => new(s._saleId, s._productId, s._salePrice, s._totalPrice, s._forAllCusts, s._startDate, s._endDate);

        public static DO.Sale CastSaleFromBOToDO(this BO.Sale s) => new(s.SaleId, s.ProductId, s.Amount, s.SalePrice, s.ForAllCusts, s.StartDate, s.EndDate);

        public static BO.SaleInProduct CastFromSaleToSaleInOrder(this BO.Sale s) => new(s.SaleId,s.Amount,s.SalePrice,s.ForAllCusts);

        public static BO.ProductInOrder CastFromProductToProductInOrder(this BO.Product p) => new(p.Barcode, p.ProductName, p.Price, p.Quantity, p.ListOfSales, p.Quantity * p.Price);

        public static string ToStringProperty<T>(this T t)
        {
            string str = "";
            Type Ttype = t!.GetType();
            PropertyInfo[] info = Ttype.GetProperties();
            foreach (PropertyInfo item in info)
            {
                if (typeof(IEnumerable).IsAssignableFrom(item.PropertyType) && item.PropertyType != typeof(string))
                {
                    IEnumerable? collection = item.GetValue(t) as IEnumerable;
                    foreach (var x in collection!)
                    {
                        str += x.ToStringProperty();
                    }
                }
                else
                    str += string.Format("name: {0,-15} value: {1,-15}\n", item.Name, item.GetValue(t, null));

            }
            return str;
        }

    }
}
