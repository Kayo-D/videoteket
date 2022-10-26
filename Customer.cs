using Dapper;
using MySqlConnector;
using static System.Console;
namespace Videoteket
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Social_Security_Number { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public void CreateCustomer(string Name, string Address, string Social_Security_Number, string Phone_Number, string Email)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"))
            {
                connection.Query($"INSERT INTO customer (Name, Address, Social_Security_Number, Phone_Number, Email) VALUES ('{Name}', '{Address}', '{Social_Security_Number}', '{Phone_Number}', '{Email}');");
            }
        }
        public string ReturnCustomerInfo(string input)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"))
            {
                string info;
                string errormessage = "This is not the customer you are looking for";
                var customerInfo = connection.Query<Customer>("SELECT ID, Name, Address, Social_Security_Number, Phone_Number, Email FROM customer;").ToList();
                foreach (Customer c in customerInfo)
                {
                    if (input == c.Name)
                    {
                        info = c.Name + c.Address + c.Social_Security_Number + c.Phone_Number + c.Email;
                        return info;
                    }
                }
                return errormessage;
            }
        }
        public string ReturnAllCustomerInfo(string input)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"))
            {
                string info;
                string errormessage = "This is not the customer you are looking for";
                var customerInfo = connection.Query<Customer>("SELECT ID, Name, Address, Social_Security_Number, Phone_Number, Email FROM customer;").ToList();
                foreach (Customer c in customerInfo)
                {
                    if (input == c.Name)
                    {
                        info = c.Name + c.Address + c.Social_Security_Number + c.Phone_Number + c.Email;
                        return info;
                    }
                }
                return errormessage;
            }
        }
    }
}
//Customer c = new Customer();
//c.CreateCustomer("måns","Varbergsvägen4","941106","0709784512","månsarn@hotmail.com");
//INSERT INTO `customer` (`ID`, `Name`, `Address`, `Social_Security_Number`, `Phone_Number`, `Email`) VALUES (NULL, 'Måns', 'Varbergsvägen4', '941106', '0709784512', 'månsarn@hotmail.com');