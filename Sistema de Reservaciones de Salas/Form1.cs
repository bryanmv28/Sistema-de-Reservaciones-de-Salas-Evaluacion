using Reservaciones.AccesoDatos;
using Reservaciones.Datos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Reservaciones
{
    public partial class Form1 : Form
    {
        private SalaDAO salaDAO = new SalaDAO();
        private ClienteDAO clienteDAO = new ClienteDAO();
        private ReservacionDAO reservacionDAO = new ReservacionDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar listas de salas y clientes al iniciar el formulario
            CargarSalas();
            CargarClientes();
        }

        private void CargarSalas()
        {
            comboBoxSalas.DisplayMember = "Nombre";
            comboBoxSalas.ValueMember = "IdSala";
            comboBoxSalas.DataSource = salaDAO.Listar();
        }

        private void CargarClientes()
        {
            comboBoxClientes.DisplayMember = "Nombre";
            comboBoxClientes.ValueMember = "IdCliente";
            comboBoxClientes.DataSource = clienteDAO.Listar();
        }

        private void btnAgregarSala_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreSala.Text) || !int.TryParse(txtCapacidad.Text, out int capacidad) || capacidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese un nombre válido y una capacidad mayor a 0.");
                return;
            }

            try
            {
                Sala sala = new Sala
                {
                    Nombre = txtNombreSala.Text,
                    Capacidad = capacidad
                };
                int newIdSala = salaDAO.Insertar(sala);
                MessageBox.Show($"Sala agregada correctamente. ID generado: {newIdSala}");
                txtNombreSala.Clear();
                txtCapacidad.Text = "0";
                CargarSalas(); // Actualizar la lista de salas
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar sala: {ex.Message}");
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre y correo válidos.");
                return;
            }

            try
            {
                Cliente cliente = new Cliente
                {
                    Nombre = txtNombreCliente.Text,
                    Correo = txtCorreo.Text
                };
                int newIdCliente = clienteDAO.Insertar(cliente);
                MessageBox.Show($"Cliente agregado correctamente. ID generado: {newIdCliente}");
                txtNombreCliente.Clear();
                txtCorreo.Clear();
                CargarClientes(); // Actualizar la lista de clientes
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cliente: {ex.Message}");
            }
        }

        private void btnAgregarReservacion_Click(object sender, EventArgs e)
        {
            if (comboBoxSalas.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una sala.");
                return;
            }

            if (comboBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un cliente.");
                return;
            }

            try
            {
                Reservacion reservacion = new Reservacion
                {
                    IdSala = (int)comboBoxSalas.SelectedValue,
                    IdCliente = (int)comboBoxClientes.SelectedValue,
                    FechaReservacion = dtpFecha.Value
                };
                reservacionDAO.Insertar(reservacion);
                MessageBox.Show("Reservación agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar reservación: {ex.Message}");
            }
        }
    }
}