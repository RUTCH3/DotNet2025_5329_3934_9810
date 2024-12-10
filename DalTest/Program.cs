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
            option = Console.ReadLine();
        }
        return option;
    }

    private static void AbsorbEntityAndCreate(string entity, string option)
    {
        switch (entity)
        {
            case "Customer":
                switch (option)
                {
                    case "Create":
                        Initialization.Initialize(IDAL.);
                        break;
                    case "Read":
                        break;
                    case "ReadAll":
                        break;
                    case "Update":
                        break;
                    case "Delete":
                        break;
                }
                break;
            case "Product":
                // Handle product actions here
                break;
            case "Sale":
                // Handle sale actions here
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
            bool continueRunning = true;

            while (continueRunning)
            {
                string entity = DisplayMainMenu();
                string option = ShowSubmenu(entity);
                AbsorbEntityAndCreate(entity, option);

                Console.WriteLine("האם אתה רוצה להמשיך? (כן/לא)");
                string? continueInput = Console.ReadLine();
                continueRunning = continueInput?.Equals("כן", StringComparison.OrdinalIgnoreCase) == true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}