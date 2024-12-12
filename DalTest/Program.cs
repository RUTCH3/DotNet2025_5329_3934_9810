using DO;
using DalApi;
using Dal;
using DalTest;

public class Program
{
    private static IDAL s_dal = new Dal.DalList();
=======
    public static IDAL s_dal = new DalList();
>>>>>>> Stashed changes

    public static void Main()
    {
        try
        {
            Initialization.Initialize(s_dal);
            DisplayMainMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
    }
<<<<<<< Updated upstream
    // פונקציה המדפיסה את שמות המחלקות למשתמש וקולטת מהמשתמש את שם המחלקה שיבחר
=======

>>>>>>> Stashed changes
    private static void DisplayMainMenu()
    {
        Console.WriteLine("Please choose the kind of object: customer/product/sale");
        string kindOfObject = Console.ReadLine();
        if (IsValidObject(kindOfObject))
        {
            CreateObject(kindOfObject);
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
<<<<<<< Updated upstream
    // פונקציה הבודקת האם הקלט תקין, כלומר האם המשתמש בחר בשם מחלקה קיימת
=======

>>>>>>> Stashed changes
    private static bool IsValidObject(string kindOfObject)
    {
        return kindOfObject.ToLower() switch
        {
            "customer" => true,
            "sale" => true,
            "product" => true,
            _ => false
        };
    }
<<<<<<< Updated upstream
    // פונקציה המציגה את אפשרויות פעולות המשתמש: יצירת אוביקט/קריאה/עדכון ומחיקה
    // הפונקציה מקבלת אוביקט כלשהו ושולחת לפונקציה שמממשת את הפעולה שהמשתמש בחר, בפרמטר נשלח את האוביקט
    private static void DisplayCrudOptions<T>(T obj) where T : class
    {
        Console.WriteLine("Please choose the function to do: create/read/update/delete");
        string? kindOfFunc = Console.ReadLine();

        switch (kindOfFunc?.ToLower())
        {
            case "create":
                CreateObject(obj);
                break;
            case "read":
                ReadObject(obj);
                break;
            case "update":
                UpdateObject(obj);
                break;
            case "delete":
                DeleteObject(obj);
                break;
            default:
                Console.WriteLine("Invalid function.");
                break;
        }
    }
<<<<<<< Updated upstream
    // פונקציה המממשת את הפעולה יצירת אוביקט מאחד הסוגים של המחלקות
    // הפונקציה מקבלת אוביקט כלשהו ויוצרת את המופע המתאים לפי סוג האוביקט
=======

>>>>>>> Stashed changes
    private static void CreateObject<T>(T obj) where T : class
    {
        switch (obj)
        {
            case Customer customer:
                s_dal.Customer.Create(customer);
                break;
            case Sale sale:
                s_dal.Sale.Create(sale);
                break;
            case Product product:
                s_dal.Product.Create(product);
                break;
        }
    }
<<<<<<< Updated upstream
    // פונקציה המממשת את הפעולה קריאת אוביקט מאחד הסוגים של המחלקות
=======

>>>>>>> Stashed changes
    private static void ReadObject<T>(T obj) where T : class
    {
        switch (obj)
        {
            case Customer customer:
                s_dal.Customer.Read(customer.customerId);
                break;
            case Sale sale:
                s_dal.Sale.Read(sale.saleId);
                break;
            case Product product:
                s_dal.Product.Read(product.productId);
                break;
        }
    }
<<<<<<< Updated upstream
    // פונקציה המממשת את הפעולה עדכון אוביקט מאחד הסוגים של המחלקות
=======

>>>>>>> Stashed changes
    private static void UpdateObject<T>(T obj) where T : class
    {
        switch (obj)
        {
            case Customer customer:
                s_dal.Customer.Update(customer);
                break;
            case Sale sale:
                s_dal.Sale.Update(sale);
                break;
            case Product product:
                s_dal.Product.Update(product);
                break;
        }
    }
<<<<<<< Updated upstream
    // פונקציה המממשת את הפעולה מחיקת אוביקט מאחד הסוגים של המחלקות
=======

>>>>>>> Stashed changes
    private static void DeleteObject<T>(T obj) where T : class
    {
        switch (obj)
        {
            case Customer customer:
<<<<<<< Updated upstream
                s_dal.Customer.Delete(customer.customerId);
                break;
            case Sale sale:
                s_dal.Sale.Delete(sale.saleId);
                break;
            case Product product:
                s_dal.Product.Delete(product.productId);
                break;
        }
    }
    // פונקציה המנהלת את יצירת האוביקטים ושולחת לכל אוביקט את הפונקציה המתאימה שיוצרת מופע
    // בהתאם לנתונים שהכניס המשתמש, ואח"כ שולחת לפונקציה שמציגה למשתמש את הפעולות האפשריות
    // ובפרמטר היא שולחת את האוביקט שנוצר לפני כן ע"י נתוני המשתמש
    private static void CreateObject(string kindOfObject)
    {
        Console.WriteLine($"Please enter details for {kindOfObject}:");

        switch (kindOfObject.ToLower())
        {
            case "customer":
                var customer = CreateCustomer();
                DisplayCrudOptions(customer);
                break;
            case "sale":
                var sale = CreateSale();
                DisplayCrudOptions(sale);
                break;
            case "product":
                var product = CreateProduct();
                DisplayCrudOptions(product);
                break;
        }
    }
<<<<<<< Updated upstream
    // פונקציה היוצרת אוביקט מסוג לקוח מהנתונים שהמשתמש מכניס
=======

>>>>>>> Stashed changes
    private static Customer CreateCustomer()
    {
        Console.WriteLine("Insert details: customerId, customerName, customerAddress, customerPhone");
        return new Customer(
            Convert.ToInt32(Console.ReadLine()),
            Console.ReadLine(),
            Console.ReadLine(),
            Console.ReadLine()
        );
    }
<<<<<<< Updated upstream
    // פונקציה היוצרת אוביקט מסוג מכירה מהנתונים שהמשתמש מכניס
=======

>>>>>>> Stashed changes
    private static Sale CreateSale()
    {
        Console.WriteLine("Insert details: saleId, saleProductId, requiredQuantityForDiscount, isIntendedForAllCustomers, finalPrice, saleStartDate, saleEndDate");
        int saleId = Convert.ToInt32(Console.ReadLine());
        int saleProductId = Convert.ToInt32(Console.ReadLine());
        int requiredQuantityForDiscount = Convert.ToInt32(Console.ReadLine());
        bool isIntendedForAllCustomers = bool.TryParse(Console.ReadLine(), out var result) && result;
        int finalPrice = Convert.ToInt32(Console.ReadLine());
        DateTime saleStartDate = DateTime.Parse(Console.ReadLine());
        DateTime saleEndDate = DateTime.Parse(Console.ReadLine());

        return new Sale(saleId, saleProductId, requiredQuantityForDiscount, isIntendedForAllCustomers, finalPrice, saleStartDate, saleEndDate);
    }
<<<<<<< Updated upstream
    // פונקציה היוצרת אוביקט מסוג מוצר מהנתונים שהמשתמש מכניס
=======

>>>>>>> Stashed changes
    private static Product CreateProduct()
    {
        Console.WriteLine("Insert details: productId, productName, category, productPrice, quantityInStock");
        int productId = Convert.ToInt32(Console.ReadLine());
<<<<<<< Updated upstream
        string? productName = Console.ReadLine();
        string? category = Console.ReadLine();
        Enum.TryParse(category, true, out Catagories chosenCategory);
        int productPrice = Convert.ToInt32(Console.ReadLine());
        int quantityInStock = Convert.ToInt32(Console.ReadLine());

        return new Product(productId, productName, chosenCategory, productPrice, quantityInStock);
    }
}