using DO;
using DalTest;
using DalApi;

public class Program
{
    public static IDAL s_dal = DalApi.Factory.Get;

    private static string DisplayMainMenu()
    {
        Console.WriteLine("Which entity would you like to add?\n" +
                "The options are: Customer, Product, Sale");
        string? entity = Console.ReadLine();
        while (entity == null || (!entity.Equals("Customer") && !entity.Equals("Product") && !entity.Equals("Sale")))
        {
            Console.WriteLine("please try agien.\n");
            Console.WriteLine("Which entity would you like to add?\n" +
            "The options are: Customer, Product, Sale");
            entity = Console.ReadLine();
        }
        return entity;
    }

    private static string ShowSubmenu(string entity)
    {
        Console.WriteLine("Which action would you like to do?\n" +
                "The options are: Create, Read, ReadAll, Update, Delete");
        string? option = Console.ReadLine();
        while (option == null || (!option.Equals("Create") && !option.Equals("Read") && !option.Equals("ReadAll") && !option.Equals("Update") && !option.Equals("Delete")))
        {
            Console.WriteLine("Please try agien.\n");
            Console.WriteLine("Which action would you like to do?\n" +
                "The options are: Create, Read, ReadAll, Update, Delete");
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
            Initialization.Initialize();
            string entity = DisplayMainMenu();
            string option = ShowSubmenu(entity);
            //if(option == "Create")
                //Initialization.
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
