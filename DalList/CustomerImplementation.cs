using DO;
using DalApi;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        int ICRUD<Customer>.Create(Customer item)
        {
            List<Customer>? list = DataSource.Customers;
            if (list != null && list.Contains(item))
            {
                throw new Exception("משתמש כבר קיים");
            }
            Customer customer = item;
            list?.Add(customer);
            return customer.Id;
        }


        Customer? ICRUD<Customer>.Read(int id)
        {
            bool find = false;
            Customer? customer = null;
            DataSource.Customers?.ForEach(c =>
            {
                if (c.Id == id)
                {
                    find = true;
                    customer = c;
                }
            });
            if (!find)
            {
                throw new Exception("משתמש אינו קיים");
            }
            return customer;
        }

        Customer ICRUD<Customer>.Read(System.Func<DO.Customer, bool> filter)
        {
            var customer = DataSource.Customers.FirstOrDefault(filter);

            if (customer == null)
            {
                throw new Exception("No customer matching the filter criteria was found.");
            }

            return customer;
        }
        List<Customer?> ICRUD<Customer>.ReadAll(System.Func<DO.Customer, bool>? filter)
        {
            if (DataSource.Customers == null)
                throw new Exception("כרגע רשימת הלקוחות ריקה!");

            if (filter != null)
            {
                return DataSource.Customers.Where(filter).ToList();
            }
            else
            {
                return DataSource.Customers.ToList();
            }
        }

        void ICRUD<Customer>.Delete(int id)
        {
            Customer? customer = null;
            DataSource.Customers?.ForEach(c =>
            {
                if (c.Id == id)
                {
                    customer = c;
                }
            });
            if (customer == null)
            {
                throw new Exception("משתמש אינו קיים");
            }
            DataSource.Customers?.Remove(customer);
        }
        void ICRUD<Customer>.Update(Customer item)
        {
            int index;
            if (DataSource.Customers == null)
                index = -1;
            else
                index = DataSource.Customers.IndexOf(item);
            if (index == -1)
            {
                throw new Exception("משתמש אינו קיים");
            }
            DataSource.Customers?.Insert(index, item);
        }


    }
}
