using Dapper;
using MySqlConnector;
using static System.Console;
//using (var connection = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"));
namespace Videoteket
{
    internal class program
    {
        private static void Main(string[] args)
        {
            //Testa inom dessa

            //Testa inom dessa
            UI menu = new UI();
            
            while (true)
            {
                menu.MenuUI();
            }
        }
    }
    /* {
        var customerList = connection.Query<Customer>("SELECT ID, Name, Address, Social_Security_Number, Phone_Number, Email FROM customer;").ToList();
        var movieList = connection.Query<Movie>("SELECT ID, Title_ID, Customer_ID, Store_Purchase_Date, Is_Retired, Rental_Price, Rent_Date, Return_Date FROM movie;").ToList();
    } */
}