using MySql.Data.MySqlClient;
using Reservaciones.AccesoDatos;
using Reservaciones.Datos;
using System.Collections.Generic;

namespace Reservaciones.AccesoDatos
{
    public class ReservacionDAO
    {
        private Conexion conexion;

        public ReservacionDAO()
        {
            conexion = new Conexion();
        }

        public void Insertar(Reservacion reservacion)
        {
            using (var conn = conexion.GetConnection())
            {
                string query = "INSERT INTO Reservaciones (id_sala, id_cliente, fecha_reservacion) VALUES (@id_sala, @id_cliente, @fecha)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_sala", reservacion.IdSala);
                cmd.Parameters.AddWithValue("@id_cliente", reservacion.IdCliente);
                cmd.Parameters.AddWithValue("@fecha", reservacion.FechaReservacion);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Reservacion> Listar()
        {
            List<Reservacion> reservaciones = new List<Reservacion>();
            using (var conn = conexion.GetConnection())
            {
                string query = "SELECT * FROM Reservaciones";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reservaciones.Add(new Reservacion
                        {
                            IdReservacion = reader.GetInt32("id_reservacion"),
                            IdSala = reader.GetInt32("id_sala"),
                            IdCliente = reader.GetInt32("id_cliente"),
                            FechaReservacion = reader.GetDateTime("fecha_reservacion")
                        });
                    }
                }
            }
            return reservaciones;
        }
    }
}