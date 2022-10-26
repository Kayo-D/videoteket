namespace Videoteket
{
public class UI
{
    static ConsoleKey menuKeys = ConsoleKey.NoName;
    Customer customerInfo = new Customer();
    public void MenuUI()
    {
        Console.WriteLine("VIDEOTEKET");
        Console.WriteLine("1. ");
        Console.WriteLine("2. ");
        Console.WriteLine("3. ");
        Console.WriteLine("4. Check customer info.");
        menuKeys = Console.ReadKey(true).Key;

        switch (menuKeys)
        {
            case ConsoleKey.D4:
            CustomerInfoUI();
            break;

            default:
            break;
        }

    }
    public void CreateReceipt()
    {

    }
    public void CreateReturnReceipt()
    {

    }
    public void CustomerInfoUI()
    {
        Console.WriteLine(customerInfo);
    }
}
}