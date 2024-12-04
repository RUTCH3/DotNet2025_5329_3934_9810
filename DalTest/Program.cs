using DO;
using DalTest;
using DalApi;
using Dal;


public class Program
{
    public static IDAL s_dal = new DalList();

    private static string DisplayMainMenu()
    {
        Console.WriteLine("איזה ישות ברצונך להוסיף?\n" +
                "האפשרויות הן: Customer, Product, Sale");
        string? entity = Console.ReadLine();
        while (entity == null || (!entity.Equals("Customer") && !entity.Equals("Product") && !entity.Equals("Sale")))
        {
            Console.WriteLine("קלט לא תקין, אנא נסה שוב\n");
            Console.WriteLine("איזה ישות ברצונך להוסיף?\n" +
            "האפשרויות הן: Customer, Product, Sale");
            entity = Console.ReadLine();
        }
        return entity;
    }

    private static string ShowSubmenu(string entity)
    {
        Console.WriteLine("איזה פעולה ברצונך לעשות?\n" +
                "האפשרויות הן: Create, Read, ReadAll, Update, Delete");
        string? option = Console.ReadLine();
        while (option == null || (!option.Equals("Create") && !option.Equals("Read") && !option.Equals("ReadAll") && !option.Equals("Update") && !option.Equals("Delete")))
        {
            Console.WriteLine("קלט לא תקין, אנא נסה שוב\n");
            Console.WriteLine("איזה פעולה ברצונך לעשות?\n" +
                "האפשרויות הן: Create, Read, ReadAll, Update, Delete");
            option = Console.ReadLine();
        }
        return option;
    }

    private static void AbsorbEntityAndCreate(string entity, string option)
    {
        switch (entity)
        {
            case "Customer":
                break;
            case "Product":
                break;
            case "Sale":
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    public static void Main()
    {
        try
        {
            Console.WriteLine("Hello, World!");
            Initialization.Initialize(s_dal);
            string entity = DisplayMainMenu();
            string option = ShowSubmenu(entity);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
