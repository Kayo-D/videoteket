using Dapper;
using MySqlConnector;
namespace Videoteket
{
    public class Customer
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Social_Security_Number { get; set; }
        public string? Phone_Number { get; set; }
        public string? Email { get; set; }
        public MySqlConnection Connection()
        {
            MySqlConnection connection = new();
            connection = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;");
            return connection;
        }
        public void CreateCustomer(string Name, string Address, string Social_Security_Number, string Phone_Number, string Email)
        {
            Connection().Query($"INSERT INTO customer (Name, Address, Social_Security_Number, Phone_Number, Email) VALUES ('{Name}', '{Address}', '{Social_Security_Number}', '{Phone_Number}', '{Email}');");
        }
        public string ReturnCustomerInfo(string input)
        {
            string errormessage = "This is not the customer you are looking for";
            var customerInfo = Connection().Query<Customer>("SELECT ID, Name, Address, Social_Security_Number, Phone_Number, Email FROM customer;").ToList();
            foreach (Customer c in customerInfo)
            {
                if (input == c.Name || input == c.Address || input == c.Social_Security_Number || input == c.Phone_Number || input == c.Email)
                {
                    return c.Name + " " + c.Address + " " + c.Social_Security_Number + " " + c.Phone_Number + " " + c.Email;
                }
            }
            return errormessage;
        }
        public List<Customer> ReturnAllCustomerInfo()
        {
            List<Customer> customerInfo = Connection().Query<Customer>("SELECT ID, Name, Address, Social_Security_Number, Phone_Number, Email FROM customer;").ToList();
            return customerInfo;
        }
    }
}