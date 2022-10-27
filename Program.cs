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

            menu.MenuUI();
        }
    }
}