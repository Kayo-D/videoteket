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
        public bool CheckBarcodeIfRented(int ID)
        {
            List<Movie> moviesInDatabase = Connection().Query<Movie>($"SELECT ID, Customer_ID FROM movie").ToList();
            foreach (var item in moviesInDatabase)
            {
                if (item.Customer_ID != 0 && item.ID == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckIfRetired(int ID)
        {
            List<Movie> moviesInDatabase = Connection().Query<Movie>($"SELECT ID, Is_Retired FROM movie").ToList();
            foreach (var item in moviesInDatabase)
            {
                if (item.Is_Retired == true && item.ID == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public void HireMovie()
        {

        }
        public void ReturnMovie(int ID)
        {
            Connection().Query($"UPDATE movie SET Customer_ID = 0, WHERE movie.id = {ID}");
        }
        //Ändra så att man skriver in titelns namn och inte Title_ID
        public void AddMovie(string Title, DateTime Store_Purchase_Date, bool Is_Retired, float Rental_Price)
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