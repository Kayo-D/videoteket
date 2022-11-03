namespace Videoteket
{
    public class UI
    {
        static ConsoleKey menuKeys = ConsoleKey.NoName;
        public void MenuUI()
        {
            while (true)
            {
                Console.WriteLine("\nVIDEOTEKET\n");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("1. Rent a movie. Press Key1");
                Console.WriteLine("2. Return a movie. Press Key2");
                Console.WriteLine("3. Create receipt. Press Key3");
                Console.WriteLine("4. Create return receipt. Press Key4");
                Console.WriteLine("5. Add a new movie. Press Key5");
                Console.WriteLine("6. Retire a movie. Press Key6");
                Console.WriteLine("7. Remove a movie. Press Key7");
                Console.WriteLine("8. Register a new customer. Press Key8");
                Console.WriteLine("9. Search for a customer. Press Key9");
                Console.WriteLine("10. List all customers. Press Key0");
                Console.WriteLine("11. Check for late returns. Press KeyA");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                menuKeys = Console.ReadKey(true).Key;

                switch (menuKeys)
                {
                    case ConsoleKey.D1:
                    RentAMovie();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.D2:
                    ReturnMovie();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.D3:
                    CreateReceipt();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.D4:
                    CreateReturnReceipt();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.D5:
                    AddAMovie();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.D6:
                    RetireAMovie();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.D7:
                    RemoveAMovie();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.D8:
                    EnterNewCustomer();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.D9:
                    CustomerInfoUI();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.D0:
                    AllCustomersInfoUI();
                    Console.ReadKey();
                    break;

                    case ConsoleKey.A:
                    LateRentals();
                    Console.ReadKey();
                    break;

                    default:
                    break;
                }               
            }
        }
        public void RentAMovie()
        {
            Console.Clear();
            Movie rentAMovie = new Movie();
            Console.WriteLine("Enter movie ID: ");
            string? movie_ID = Console.ReadLine();
            Console.WriteLine("Enter Customer ID: ");
            string? customer_ID = Console.ReadLine();
            Console.WriteLine("Date of rent day: ");
            string? dateTime = Console.ReadLine();
        }
        public void ReturnMovie()
        {
            Console.Clear();
            Movie returnMovie = new Movie();
            Console.WriteLine("Enter movie ID: ");
            string? movie_ID = Console.ReadLine();
        }
        public void CreateReceipt()
        {

        }
        public void CreateReturnReceipt()
        {

        }
        public void AddAMovie()
        {

        }
        public void RetireAMovie()
        {

        }
        public void RemoveAMovie()
        {

        }
        public void EnterNewCustomer()
        {
            Console.Clear();
            Customer addNewCustomer = new Customer();
            Console.WriteLine("Enter customer name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter customer address: ");
            string? address = Console.ReadLine();
            Console.WriteLine("Enter customer social security number: ");
            string? social_Security_Number = Console.ReadLine();

            while (true)
            {
                if (social_Security_Number == "")
                {
                    Console.WriteLine("You can't leave this field blank. Please try again.");
                    social_Security_Number = Console.ReadLine();
                }
                else if (social_Security_Number.Length < 10)
                {
                    Console.WriteLine("Security number too short. You have to enter 10 digits. Please try again.");
                    social_Security_Number = Console.ReadLine();
                }
                else if (social_Security_Number.Length > 10)
                {
                    Console.WriteLine("Security number too long. You have to enter 10 digits. Please try again.");
                    social_Security_Number = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine("Enter customer phone number: ");
            string? phone_Number = Console.ReadLine();

            while (true)
            {
                if (phone_Number == "")
                {
                    Console.WriteLine("You can't leave this field blank. Please try again.");
                    phone_Number = Console.ReadLine();
                }
                else if (phone_Number.Length < 9)
                {
                    Console.WriteLine("Phone number too short. Please try again.");
                    phone_Number = Console.ReadLine();
                }
                else if (phone_Number.Length > 10)
                {
                    Console.WriteLine("Phone number too long. Please try again.");
                    phone_Number = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Enter customer email: ");
            string? email = Console.ReadLine();
            addNewCustomer.CreateCustomer(name, address, social_Security_Number, phone_Number, email);
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
        public void LateRentals()
        {

        }
    }
}