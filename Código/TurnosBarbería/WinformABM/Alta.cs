using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;

namespace WinformABM
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            // Cargar clientes
            listaClientes.DataSource = ClienteRepository.ObtenerTodos();

            // Cargar servicios
            listaServicios.DataSource = ServicioRepository.ObtenerTodos();

            // Cargar peluqueros
            listaPeluqueros.DataSource = PeluqueroRepository.ObtenerTodos();

            // Cargar horas (ejemplo: lista fija)
        }

        private void btnAgregar_Click_Click(object sender, EventArgs e)
        {
            // Obtener datos seleccionados
            var cliente = listaClientes.CurrentRow?.DataBoundItem as Cliente;
            var servicio = listaServicios.CurrentRow?.DataBoundItem as Servicio;
            var peluquero = listaPeluqueros.CurrentRow?.DataBoundItem as Peluquero;

            MessageBox.Show("Turno guardado correctamente.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes usar este evento para mostrar detalles o editar el elemento seleccionado
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Si tienes un filtro de búsqueda, implementa aquí la lógica
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No suele ser necesario implementar nada aquí
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Si tienes otro filtro, implementa aquí la lógica
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
