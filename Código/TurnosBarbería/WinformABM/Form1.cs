using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;

namespace WinformABM
{
    public partial class Form1 : Form
    {
        public Form1()
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
            listaHoras.DataSource = new List<string> { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00" };
        }

        private void btnAgregar_Click_Click(object sender, EventArgs e)
        {
            // Obtener datos seleccionados
            var cliente = listaClientes.CurrentRow?.DataBoundItem as Cliente;
            var servicio = listaServicios.CurrentRow?.DataBoundItem as Servicio;
            var peluquero = listaPeluqueros.CurrentRow?.DataBoundItem as Peluquero;
            var hora = listaHoras.CurrentRow?.Cells[0].Value?.ToString();
            var fechaTexto = Fecha.Text;

            if (cliente == null || servicio == null || peluquero == null || string.IsNullOrEmpty(hora) || string.IsNullOrEmpty(fechaTexto))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (!DateTime.TryParse($"{fechaTexto} {hora}", out DateTime fechaYHora))
            {
                MessageBox.Show("Fecha u hora inválida.");
                return;
            }

            var turno = new Turno
            {
                FechaYHora = fechaYHora,
                // Aquí deberías agregar las propiedades de relación si existen (ejemplo: ClienteId, ServicioId, PeluqueroId)
            };

            TurnoRepository.Agregar(turno);
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
    }
}
