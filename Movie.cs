/* Funktioner

CheckBarcode(Movie)
CheckIfRetired(Movie)
ChangeStockAmount(Movie)
HireMovie(Movie)
ReturnMovie(Movie)
AddMovie(Movie)
RetireMovie(Movie)
ChangeStockAmount(Movie)
RemoveMovie(Movie)
CheckForLateReturns(Movie) */
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
}