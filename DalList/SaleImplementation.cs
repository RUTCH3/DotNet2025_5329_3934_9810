using DO;
using DalApi;
using static Dal.DataSource;
using Tools;
using System.Reflection;


namespace Dal
{
    internal class SaleImplementation : ISale
    {
        int ICRUD<Sale>.Create(Sale item)
        {
            LogManager.WriteToLog("start delete the customer.", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            List<Sale>? list = DataSource.Sales;
            if (list != null && list.Contains(item))
            {
                throw new Exception("מבצע כבר קיים");
            }
            Sale sale = item;
            list?.Add(sale);
            return sale._saleId;
        }


        Sale? ICRUD<Sale>.Read(int id)
        {
            bool find = false;
            Sale? sale = null;
            DataSource.Sales?.ForEach(s =>
            {
                if (s._saleId == id)
                {
                    find = true;
                    sale = s;
                }
            });
            if (!find)
            {
                throw new Exception("מבצע אינו קיים");
            }
            return sale;
        }

        List<Sale> ICRUD<Sale>.ReadAll()
        {
            if (DataSource.Sales == null)
                throw new Exception("כרגע אין מבצעים!");
            return DataSource.Sales;
        }

        void ICRUD<Sale>.Delete(int id)
        {
            Sale? sale = null;
            DataSource.Sales?.ForEach(s =>
            {
                if (s._saleId == id)
                {
                    sale = s;
                }
            });
            if (sale == null)
            {
                throw new Exception("מבצע אינו קיים");
            }
            DataSource.Sales?.Remove(sale);
        }
        void ICRUD<Sale>.Update(Sale item)
        {
            int index;
            if (DataSource.Sales == null)
                index = -1;
            else
                index = DataSource.Sales.IndexOf(item);
            if (index == -1)
            {
                throw new Exception("מבצע אינו קיים");
            }
            DataSource.Sales?.Insert(index, item);
        }
    }
}

