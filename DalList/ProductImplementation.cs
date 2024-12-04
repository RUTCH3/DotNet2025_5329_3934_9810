using DO;
using DalApi;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        int ICRUD<Product>.Create(Product item)
        {
            List<Product>? list = DataSource.Products;
            if (list != null && list.Contains(item))
            {
                throw new Exception("משתמש כבר קיים");
            }
            Product product = item;
            list?.Add(product);
            return product.Barcode;
        }
        Product? ICRUD<Product>.Read(int id)
        {
            bool find = false;
            Product? product = null;
            DataSource.Products?.ForEach(p =>
            {
                if (p.Barcode == id)
                {
                    find = true;
                    product = p;
                }
            });
            if (!find)
            {
                throw new Exception("מוצר אינו קיים");
            }
            return product;
        }

        Product ICRUD<Product>.Read(System.Func<DO.Product, bool> filter)
        {
            var product = DataSource.Products.FirstOrDefault(filter);

            if (product == null)
            {
                throw new Exception("No customer matching the filter criteria was found.");
            }

            return product;
        }
        List<Product?> ICRUD<Product>.ReadAll(System.Func<DO.Product, bool>? filter)
        {
            if (DataSource.Products == null)
                throw new Exception("כרגע רשימת הלקוחות ריקה!");

            if (filter != null)
            {
                return DataSource.Products.Where(filter).ToList();
            }
            else
            {
                return DataSource.Products.ToList();
            }
        }

        void ICRUD<Product>.Delete(int id)
        {
            Product? product = null;
            DataSource.Products?.ForEach(p =>
            {
                if (p.Barcode == id)
                {
                    product = p;
                }
            });
            if (product == null)
            {
                throw new Exception("מוצר אינו קיים");
            }
            DataSource.Products?.Remove(product);
        }
        void ICRUD<Product>.Update(Product item)
        {
            int index;
            if (DataSource.Products == null)
                index = -1;
            else
                index = DataSource.Products.IndexOf(item);
            if (index == -1)
            {
                throw new Exception("מוצר אינו קיים");
            }
            DataSource.Products?.Insert(index, item);
        }
    }
}
