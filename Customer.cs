using Dapper;
using MySqlConnector;
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