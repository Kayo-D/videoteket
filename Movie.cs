using Dapper;
using MySqlConnector;
using (var movielist = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;"))
{
    var movie = movielist.Query<Movie>("SELECT ID, Title_ID, Customer_ID, Store_Purchase_Date, Is_Retired, Rental_Price, Rent_Date, Return_Date FROM movie;").ToList();
}
public class Movie
{
    public int ID { get; set; }
    public int Title_ID { get; set; }
    public int Customer_ID { get; set; }
    public DateTime Store_Purchase_Date { get; set; }
    public bool Is_Retired { get; set; }
    public float Rental_Price { get; set; }
    public DateTime Rent_Date { get; set; }
    public DateTime Return_Date { get; set; }
    public void CheckBarcode()
    {

    }
    public void CheckIfRetired()
    {

    }
    public void ChangeStockAmount()
    {

    }
    public void HireMovie()
    {

    }
    public void ReturnMovie()
    {

    }
    public void AddMovie()
    {

    }
    public void RetireMovie()
    {

    }
    public void ChangeStockAmount()
    {

    }
    public void RemoveMovie()
    {

    }
    public void CheckForLateReturns()
    {

    }
}