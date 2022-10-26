using Dapper;
using MySqlConnector;
using static System.Console;

using (var movielist = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"))
{
    var movie = movielist.Query<Movie>("SELECT ID, Title_ID, Customer_ID, Store_Purchase_Date, Is_Retired, Rental_Price, Rent_Date, Return_Date FROM movie;").ToList();
    foreach (Movie m in movie)
    {
        WriteLine(m.ID + "  " + m.Title_ID + " " + m.Customer_ID + " " + m.Store_Purchase_Date + " " + m.Is_Retired + " " + m.Rental_Price + " " + m.Rent_Date + " " + m.Return_Date);
    }
}
using (var customerlist = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"))
{
    var customer = customerlist.Query<Customer>("SELECT ID, Name, Address, Social_Security_Number, Phone_Number, Email FROM customer;").ToList();
    foreach (Customer c in customer)
    {
        WriteLine(c.ID + " " + c.Name + " " + c.Address + " " + c.Social_Security_Number + " " + c.Phone_Number + " " + c.Email);
    }
}
ReadLine();