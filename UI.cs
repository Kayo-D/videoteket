namespace Videoteket
{
public class UI
{
    static ConsoleKey menuKeys = ConsoleKey.NoName;
    public void MenuUI()
    {
        while (true)
        {
            Console.WriteLine("VIDEOTEKET");
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. Register a new customer.");
            Console.WriteLine("4. Search for a customer.");
            Console.WriteLine("5. List all customers.");
            menuKeys = Console.ReadKey(true).Key;

            switch (menuKeys)
            {
                case ConsoleKey.D3:
                EnterNewCustomer();
                Console.ReadKey();
                break;

                case ConsoleKey.D4:
                CustomerInfoUI();
                Console.ReadKey();
                break;

                case ConsoleKey.D5:
                AllCustomersInfoUI();
                Console.ReadKey();
                break;

                default:
                break;
            }
            
        }
    }
    public void CreateReceipt()
    {

    }
    public void CreateReturnReceipt()
    {

    }

    public void EnterNewCustomer()
    {
        Customer addNewCustomer = new Customer();
        Console.WriteLine("Enter customer name: ");
        string? Name = Console.ReadLine();
        Console.WriteLine("Enter customer address: ");
        string? Address = Console.ReadLine();
        Console.WriteLine("Enter customer social security number: ");
        string? Social_Security_Number = Console.ReadLine();
        Console.WriteLine("Enter customer phone number: ");
        string? Phone_Number = Console.ReadLine();
        Console.WriteLine("Enter customer email: ");
        string? Email = Console.ReadLine();
        addNewCustomer.CreateCustomer(Name, Address, Social_Security_Number, Phone_Number, Email);

    }

    public void CustomerInfoUI()
    {
        Console.Clear();
        Customer customerInfo = new Customer();
        Console.WriteLine("Enter a customer name to search for.");
        string? input = Console.ReadLine();
        Console.WriteLine(customerInfo.ReturnCustomerInfo(input));
    }
    public void AllCustomersInfoUI()
    {
        Console.Clear();
        List<Customer> allcustomers = new();
        Customer customerInfo = new Customer();
        Console.WriteLine("All registered customers: ");
        allcustomers = customerInfo.ReturnAllCustomerInfo();
        foreach(var item in allcustomers)
        {
            Console.WriteLine(item.Name + " " + item.Address + " " + item.Social_Security_Number + " " + item.Phone_Number + " " + item.Email);
        }
    }
}
}