using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;
using ClasesEjercicioPrueba.Data1;

namespace WinformABM
{
    public partial class FormAltaTurno : Form
    {
        private Turno turnoEditando;

        public FormAltaTurno()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

        // Constructor para edición
        public FormAltaTurno(Turno turno) : this()
        {
            turnoEditando = turno;
            InicializarParaEdicion();
        }

        private void FormAltaTurno_Load(object sender, EventArgs e)
        {
            // No hace falta instanciar repositorios, son estáticos
            listaClientes.DataSource = ClienteRepository.ObtenerTodos();
            listaServicios.DataSource = ServicioRepository.ObtenerTodos();
            listaPeluqueros.DataSource = PeluqueroRepository.ObtenerTodos();

            listaClientes.SelectedIndex = -1;
            listaServicios.SelectedIndex = -1;
            listaPeluqueros.SelectedIndex = -1;
        }

        private void InicializarParaEdicion()
        {
            if (turnoEditando == null) return;

            // Selecciona el cliente
            listaClientes.SelectedItem =
                ClienteRepository.ObtenerTodos()
                                 .Find(c => c.Id == turnoEditando.ClienteId);

            // Selecciona el servicio
            listaServicios.SelectedItem =
                ServicioRepository.ObtenerTodos()
                                  .Find(s => s.Id == turnoEditando.ServicioId);

            // Selecciona el peluquero
            listaPeluqueros.SelectedItem =
                PeluqueroRepository.ObtenerTodos()
                                   .Find(p => p.Id == turnoEditando.PeluqueroId);

            // Si tenés DateTimePicker para la fecha/hora
            // dateTimePicker1.Value = turnoEditando.Fecha;
        }

        private void CargarDatosIniciales()
        {
            // Igual que en Load, se puede llamar desde aquí si prefieres
            listaClientes.DataSource = ClienteRepository.ObtenerTodos();
            listaServicios.DataSource = ServicioRepository.ObtenerTodos();
            listaPeluqueros.DataSource = PeluqueroRepository.ObtenerTodos();

            listaClientes.SelectedIndex = -1;
            listaServicios.SelectedIndex = -1;
            listaPeluqueros.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var cliente = listaClientes.SelectedItem as Cliente;
            var servicio = listaServicios.SelectedItem as Servicio;
            var peluquero = listaPeluqueros.SelectedItem as Peluquero;

            if (cliente == null || servicio == null || peluquero == null)
            {
                MessageBox.Show("Debe seleccionar cliente, servicio y peluquero.");
                return;
            }

            if (turnoEditando != null)
            {
                // Actualiza turno existente
                turnoEditando.ClienteId = cliente.Id;
                turnoEditando.ServicioId = servicio.Id;
                turnoEditando.PeluqueroId = peluquero.Id;
                // turnoEditando.Fecha = dateTimePicker1.Value;

                TurnoRepository.Actualizar(turnoEditando);
                MessageBox.Show("Turno modificado correctamente.");
            }
            else
            {
                // Crear nuevo turno
                var nuevoTurno = new Turno
                {
                    ClienteId = cliente.Id,
                    ServicioId = servicio.Id,
                    PeluqueroId = peluquero.Id,
                    // Fecha = dateTimePicker1.Value
                };

                TurnoRepository.Agregar(nuevoTurno);
                MessageBox.Show("Turno guardado correctamente.");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
