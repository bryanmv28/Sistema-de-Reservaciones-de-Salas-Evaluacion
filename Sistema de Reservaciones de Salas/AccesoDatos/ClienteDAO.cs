using MySql.Data.MySqlClient;
using Reservaciones.AccesoDatos;
using Reservaciones.Datos;
using System.Collections.Generic;

namespace Reservaciones.AccesoDatos
{
    public class ClienteDAO
    {
        private Conexion conexion;

        public ClienteDAO()
        {
            conexion = new Conexion();
        }

        public int Insertar(Cliente cliente)
        {
            using (var conn = conexion.GetConnection())
            {
                string query = "INSERT INTO Clientes (nombre, correo) VALUES (@nombre, @correo)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@correo", cliente.Correo);
                cmd.ExecuteNonQuery();
                // Obtener el último ID insertado
                return (int)cmd.LastInsertedId;
            }
        }

        public List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var conn = conexion.GetConnection())
            {
                string query = "SELECT * FROM Clientes";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new Cliente
                        {
                            IdCliente = reader.GetInt32("id_cliente"),
                            Nombre = reader.GetString("nombre"),
                            Correo = reader.GetString("correo")
                        });
                    }
                }
            }
            return clientes;
        }
    }
}