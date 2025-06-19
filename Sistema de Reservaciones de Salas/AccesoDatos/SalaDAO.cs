using MySql.Data.MySqlClient;
using Reservaciones.AccesoDatos;
using Reservaciones.Datos;
using System.Collections.Generic;

namespace Reservaciones.AccesoDatos
{
    public class SalaDAO
    {
        private Conexion conexion;

        public SalaDAO()
        {
            conexion = new Conexion();
        }

        public int Insertar(Sala sala)
        {
            using (var conn = conexion.GetConnection())
            {
                string query = "INSERT INTO Salas (nombre, capacidad) VALUES (@nombre, @capacidad)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", sala.Nombre);
                cmd.Parameters.AddWithValue("@capacidad", sala.Capacidad);
                cmd.ExecuteNonQuery();
                // Obtener el último ID insertado
                return (int)cmd.LastInsertedId;
            }
        }

        public List<Sala> Listar()
        {
            List<Sala> salas = new List<Sala>();
            using (var conn = conexion.GetConnection())
            {
                string query = "SELECT * FROM Salas";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        salas.Add(new Sala
                        {
                            IdSala = reader.GetInt32("id_sala"),
                            Nombre = reader.GetString("nombre"),
                            Capacidad = reader.GetInt32("capacidad")
                        });
                    }
                }
            }
            return salas;
        }
    }
}
