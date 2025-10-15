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

       
        public FormAltaTurno(int turnoId) : this()
        {
            turnoEditando = TurnoRepository.ObtenerPorId(turnoId);
        }


        private void FormAltaTurno_Load(object sender, EventArgs e)
        {
            listaClientes.DataSource = ClienteRepository.ObtenerTodos();
            listaServicios.DataSource = ServicioRepository.ObtenerTodos();
            listaPeluqueros.DataSource = PeluqueroRepository.ObtenerTodos();

            listaClientes.DisplayMember = "Nombre";
            listaClientes.ValueMember = "Id";

            listaServicios.DisplayMember = "Descripcion";
            listaServicios.ValueMember = "Id";

            listaPeluqueros.DisplayMember = "Nombre";
            listaPeluqueros.ValueMember = "Id";

            if (turnoEditando != null)
            {
                listaClientes.SelectedValue = turnoEditando.ClienteId;
                listaServicios.SelectedValue = turnoEditando.ServicioId;
                listaPeluqueros.SelectedValue = turnoEditando.PeluqueroId;
                dateTimePicker1.Value = turnoEditando.Fecha;
            }
            else
            {
                listaClientes.SelectedIndex = -1;
                listaServicios.SelectedIndex = -1;
                listaPeluqueros.SelectedIndex = -1;
            }
        }



      


        private void CargarDatosIniciales()
        {
           
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
          
                turnoEditando.ClienteId = cliente.Id;
                turnoEditando.ServicioId = servicio.Id;
                turnoEditando.PeluqueroId = peluquero.Id;
                turnoEditando.Fecha = dateTimePicker1.Value;

                TurnoRepository.Actualizar(turnoEditando);
                MessageBox.Show("Turno modificado correctamente.");
            }
            else
            {
               
                var nuevoTurno = new Turno
                {
                    ClienteId = cliente.Id,
                    ServicioId = servicio.Id,
                    PeluqueroId = peluquero.Id,
                    Fecha = dateTimePicker1.Value
                };

                TurnoRepository.Agregar(nuevoTurno);
                MessageBox.Show("Turno guardado correctamente.");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
