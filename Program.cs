using Dapper;
using MySqlConnector;
using static System.Console;

using (var connection = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"))
{
    var movie = connection.Query<Movie>("SELECT ID, Title_ID, Customer_ID, Store_Purchase_Date, Is_Retired, Rental_Price, Rent_Date, Return_Date FROM movie;").ToList();
    foreach (Movie m in movie)
    {
        WriteLine(m.ID + "  " + m.Title_ID + " " + m.Customer_ID + " " + m.Store_Purchase_Date + " " + m.Is_Retired + " " + m.Rental_Price + " " + m.Rent_Date + " " + m.Return_Date);
    }
}
ReadLine();