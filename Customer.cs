using Dapper;
using MySqlConnector;
using (var customerlist = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"))
{
    var customer = customerlist.Query<Customer>("SELECT ID, Name, Address, Social_Security_Number, Phone_Number, Email FROM customer;").ToList();
}
public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Social_Security_Number { get; set; }
    public string Phone_Number { get; set; }
    public string Email { get; set; }
    public void CreateCustomer()
    {

    }
    public void ReturnCustomerInfo()
    {

    }
}