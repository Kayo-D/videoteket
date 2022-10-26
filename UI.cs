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
            Console.WriteLine("3. ");
            Console.WriteLine("4. Check customer info.");
            menuKeys = Console.ReadKey(true).Key;

            switch (menuKeys)
            {
                case ConsoleKey.D4:
                CustomerInfoUI();
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
    public void CustomerInfoUI()
    {
        Customer customerInfo = new Customer();
        Console.WriteLine("Vem vill du söka på i databasen?");
        string input = Console.ReadLine();
        Console.WriteLine(customerInfo.ReturnCustomerInfo(input));
    }
}
}