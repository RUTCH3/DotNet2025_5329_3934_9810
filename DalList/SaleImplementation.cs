using DO;
using DalApi;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        int ICRUD<Sale>.Create(Sale item)
        {
            List<Sale>? list = DataSource.Sales;
            if (list != null && list.Contains(item))
            {
                throw new Exception("מבצע כבר קיים");
            }
            Sale sale = item;
            list?.Add(sale);
            return sale.SaleId;
        }
        Sale? ICRUD<Sale>.Read(int id)
        {
            bool find = false;
            Sale? sale = null;
            DataSource.Sales?.ForEach(s =>
            {
                if (s.SaleId == id)
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

        Sale ICRUD<Sale>.Read(System.Func<DO.Sale, bool> filter)
        {
            var sale = DataSource.Sales.FirstOrDefault(filter);

            if (sale == null)
            {
                throw new Exception("No customer matching the filter criteria was found.");
            }

            return sale;
        }
        List<Sale?> ICRUD<Sale>.ReadAll(System.Func<DO.Sale, bool>? filter)
        {
            if (DataSource.Sales == null)
                throw new Exception("כרגע רשימת הלקוחות ריקה!");

            if (filter != null)
            {
                return DataSource.Sales.Where(filter).ToList();
            }
            else
            {
                return DataSource.Sales.ToList();
            }
        }

        void ICRUD<Sale>.Delete(int id)
        {
            Sale? sale = null;
            DataSource.Sales?.ForEach(s =>
            {
                if (s.SaleId == id)
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

