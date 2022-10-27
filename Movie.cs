using Dapper;
using MySqlConnector;
namespace Videoteket
{
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
        public MySqlConnection Connection()
        {
            MySqlConnection connection = new();
            connection = new MySqlConnection("Server=localhost;Database=videoteket;Uid=root;");
            return connection;
        }
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
        //Ändra så att man skriver in titelns namn och inte Title_ID
        public void AddMovie(int Title_ID, DateTime Store_Purchase_Date, bool Is_Retired, float Rental_Price)
        {
            Connection().Query($"INSERT INTO movie (Title_ID, Store_Purchase_Date, Is_Retired, Rental_Price) VALUES ('{Title_ID}', '{Store_Purchase_Date}', '{Is_Retired}', '{Rental_Price}');");
        }
        public void RetireMovie(int ID)
        {
            Connection().Query($"UPDATE movie SET Is_Retired = 1 WHERE movie.ID = {ID}");
        }
        public void RemoveMovie(int ID)
        {
            Connection().Query($"DELETE FROM movie WHERE `movie`.`ID` = {ID}");
        }
        public bool CheckForLateReturns()
        {
            DateTime today = DateTime.Now;
            DateTime min = new();
            List<Movie> moviesInDatabase = Connection().Query<Movie>($"SELECT ID, Return_Date FROM movie").ToList();
            foreach (var item in moviesInDatabase)
            {
                int value = DateTime.Compare(item.Return_Date, today);
                if (value < 0 && item.Return_Date != min)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Movie> ReturnLateMoviesList()
        {
            DateTime today = DateTime.Now;
            DateTime min = new();
            List<Movie> returnList = new();
            List<Movie> moviesInDatabase = Connection().Query<Movie>($"SELECT ID, Return_Date FROM movie").ToList();
            foreach (var item in moviesInDatabase)
            {
                int value = DateTime.Compare(item.Return_Date, today);
                if (value < 0 && item.Return_Date != min)
                {
                    returnList.Add(item);
                }
            }
            return returnList;
        }
    }
}