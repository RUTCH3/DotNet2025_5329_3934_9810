using DO;
using DalApi;
using static Dal.DataSource;
using Tools;
using System.Reflection;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        int ICRUD<Customer>.Create(Customer item)
        {
            LogManager.WriteToLog("start creating a customer.");
            List<Customer>? list = DataSource.Customers;
            if (list != null && list.Contains(item))
            {
                LogManager.WriteToLog("can't creating customer already exist.");
                throw new Exception("משתמש כבר קיים");
            }
            Customer customer = item;
            list?.Add(customer);
            LogManager.WriteToLog("finish creating a customer.");
            return customer._id;
        }


        Customer? ICRUD<Customer>.Read(int id)
        {
            LogManager.WriteToLog("start get a customer.");
            bool find = false;
            Customer? customer = null;
            DataSource.Customers?.ForEach(c =>
            {
                if (c._id == id)
                {
                    find = true;
                    customer = c;
                }
            });
            if (!find)
            {
                throw new Exception("משתמש אינו קיים");
            }
            LogManager.WriteToLog("finish get a customer.");
            return customer;
        }

        List<Customer> ICRUD<Customer>.ReadAll()
        {
            LogManager.WriteToLog("start get all customers.");
            if (DataSource.Customers == null)
            {
                LogManager.WriteToLog("no customers exist.");
                throw new Exception("כרגע רשימת הלקוחות ריקה!");
            }
            LogManager.WriteToLog("finish get all customers.");
            return DataSource.Customers;
        }

        void ICRUD<Customer>.Delete(int id)
        {
            LogManager.WriteToLog("start delete the customer.");
            Customer? customer = null;
            DataSource.Customers?.ForEach(c =>
            {
                if (c._id == id)
                {
                    customer = c;
                }
            });
            if (customer == null)
            {
                LogManager.WriteToLog("can't delete, customer not exist.");
                throw new Exception("משתמש אינו קיים");
            }
            LogManager.WriteToLog("finish delete the customer.");
            DataSource.Customers?.Remove(customer);
        }
        void ICRUD<Customer>.Update(Customer item)
        {
            LogManager.WriteToLog("start update the customer.");
            int index;
            if (DataSource.Customers == null)
                index = -1;
            else
                index = DataSource.Customers.IndexOf(item);
            if (index == -1)
            {
                LogManager.WriteToLog("can't update, customer not exist.");
                throw new Exception("משתמש אינו קיים");
            }
            LogManager.WriteToLog("start update the customer.");
            DataSource.Customers?.Insert(index, item);
        }


    }
}
