using MySql.Data.MySqlClient;

namespace Reservaciones.AccesoDatos
{
    public class Conexion
    {
        private static readonly string connectionString = "Server=localhost;Database=Reservaciones;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(connectionString);
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            return connection;
        }
    }
}