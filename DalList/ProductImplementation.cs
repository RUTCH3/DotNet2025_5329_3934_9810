using DO;
using DalApi;
using static Dal.DataSource;
using Tools;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        int ICRUD<Product>.Create(Product item)
        {
            LogManager.WriteToLog("start creating a product.");
            List<Product>? list = DataSource.Products;
            if (list != null && list.Contains(item))
            {
                LogManager.WriteToLog("can't creating the product, already exist.");
                throw new Exception("מוצר כבר קיים");
            }
            Product product = item;
            list?.Add(product);
            LogManager.WriteToLog("finish creating a product.");
            return product._barcode;
        }


        Product? ICRUD<Product>.Read(int id)
        {
            LogManager.WriteToLog("start get the product.");
            bool find = false;
            Product? product = null;
            DataSource.Products?.ForEach(p =>
            {
                if (p._barcode == id)
                {
                    find = true;
                    product = p;
                }
            });
            if (!find)
            {
                LogManager.WriteToLog("can't get the product, not exist.");
                throw new Exception("מוצר אינו קיים");
            }
            LogManager.WriteToLog("finish get the product.");
            return product;
        }

        List<Product> ICRUD<Product>.ReadAll()
        {
            LogManager.WriteToLog("start get all the products.");
            if (DataSource.Products == null)
            {
                LogManager.WriteToLog("can't find any products.");
                throw new Exception("כרגע רשימת המוצרים ריקה!");
            }
            LogManager.WriteToLog("finish get the products.");
            return DataSource.Products;
        }

        void ICRUD<Product>.Delete(int id)
        {
            LogManager.WriteToLog("start delete the product.");
            Product? product = null;
            DataSource.Products?.ForEach(p =>
            {
                if (p._barcode == id)
                {
                    product = p;
                }
            });
            if (product == null)
            {
                LogManager.WriteToLog("can't delete the product, not exist.");
                throw new Exception("מוצר אינו קיים");
            }
            LogManager.WriteToLog("finish delete the product.");
            DataSource.Products?.Remove(product);
        }
        void ICRUD<Product>.Update(Product item)
        {
            LogManager.WriteToLog("start update the product.");
            int index;
            if (DataSource.Products == null)
                index = -1;
            else
                index = DataSource.Products.IndexOf(item);
            if (index == -1)
            {
                LogManager.WriteToLog("can't update the product, not exist.");
                throw new Exception("מוצר אינו קיים");
            }
            LogManager.WriteToLog("finish get the product.");
            DataSource.Products?.Insert(index, item);
        }
    }
}
