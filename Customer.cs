using Dapper;
using MySqlConnector;
using (var connection = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"));
public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Social_Security_Number { get; set; }
    public string Phone_Number { get; set; }
    public string Email { get; set; }
    private var customerList = connection.Query<Customer>("SELECT ID, Name, Address, Social_Security_Number, Phone_Number, Email FROM customer;").ToList();
    public void CreateCustomer()
    {
        
    }
    public void ReturnCustomerInfo()
    {

    }
}