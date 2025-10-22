using System;
using System.Windows.Forms;
using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;
using ClasesEjercicioPrueba.Data1;

namespace WinformABM
{
    public partial class FormListaTurnos : Form
    {
        public FormListaTurnos()
        {
            InitializeComponent();
        }

        private void FormListaTurnos_Load(object sender, EventArgs e)
        {
            dataGridViewTurnos.AutoGenerateColumns = false;
            dataGridViewTurnos.Columns.Clear();

            dataGridViewTurnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cliente",
                DataPropertyName = "ClienteNombre"
            });
            dataGridViewTurnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Servicio",
                DataPropertyName = "ServicioNombre"
            });
            dataGridViewTurnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Peluquero",
                DataPropertyName = "PeluqueroNombre"
            });
            dataGridViewTurnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha",
                DataPropertyName = "Fecha"
            });
            dataGridViewTurnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Hora",
                DataPropertyName = "Hora"
            });



            CargarClientes();
            CargarTurnos();
            CargarTurnosPorFecha(DateTime.Today);
        }

        private void CargarTurnos()
        {
            var lista = TurnoRepository.ObtenerTodos();
            dataGridViewTurnos.DataSource = null;
            dataGridViewTurnos.DataSource = lista;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltaTurno formAlta = new FormAltaTurno();
            formAlta.Owner = this;
            if (formAlta.ShowDialog() == DialogResult.OK)
            {
                CargarTurnos();
                CargarTurnosPorFecha(dtpFiltrarFecha.Value);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTurnos.CurrentRow?.DataBoundItem is Turno turno)
            {

                FormAltaTurno formEditar = new FormAltaTurno(turno.Id);
                formEditar.Owner = this;
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    CargarTurnos();
                    CargarTurnosPorFecha(dtpFiltrarFecha.Value);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un turno para editar.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTurnos.CurrentRow?.DataBoundItem is Turno turno)
            {
                var resultado = MessageBox.Show("¿Está seguro que desea eliminar el turno?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    TurnoRepository.Eliminar(turno);
                    CargarTurnos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un turno para eliminar.");
            }
            CargarTurnosPorFecha(dtpFiltrarFecha.Value);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormFiltradoPorPeluquero reporte = new FormFiltradoPorPeluquero();
            reporte.ShowDialog();
        }


        private void CargarClientes()
        {
            ListBoxListaClientes.DataSource = null;
            ListBoxListaClientes.DataSource = ClienteRepository.ObtenerTodos();
            ListBoxListaClientes.DisplayMember = "Nombre";
            ListBoxListaClientes.ValueMember = "Id";
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormAltaCliente formAlta = new FormAltaCliente();
            formAlta.Owner = this;
            if (formAlta.ShowDialog() == DialogResult.OK)
            {
                CargarClientes();
            }
        }


        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            var clienteSeleccionado = ListBoxListaClientes.SelectedItem as Cliente;
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para editar.");
                return;
            }

            FormAltaCliente formAlta = new FormAltaCliente(clienteSeleccionado.Id);
            formAlta.Owner = this;
            if (formAlta.ShowDialog() == DialogResult.OK)
            {
                CargarTurnos();
                CargarClientes();
                CargarTurnosPorFecha(dtpFiltrarFecha.Value);
            }
        }


        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            var clienteSeleccionado = ListBoxListaClientes.SelectedItem as Cliente;
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.");
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Está seguro que desea eliminar al cliente {clienteSeleccionado.Nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                ClienteRepository.Eliminar(clienteSeleccionado.Id);
                CargarTurnos();
                CargarClientes();
                CargarTurnosPorFecha(dtpFiltrarFecha.Value);

            }
        }

        public void CargarTurnosPorFecha(DateTime fecha)
        {
            var turnos = TurnoRepository.ObtenerTodos()
                .Where(t => t.Fecha.Date == fecha.Date)
                .Select(t => new
                {
                    Cliente = t.Cliente.Nombre,
                    Peluquero = t.Peluquero.Nombre,
                    Servicio = t.Servicio.Nombre,
                    Hora = t.Hora.ToString(@"hh\:mm") // si Hora es TimeSpan
                })
                .ToList();

            dataGridViewFiltroTurnos.DataSource = turnos;
        }

        private void btnFiltrarTurnos_Click(object sender, EventArgs e)
        {
            CargarTurnosPorFecha(dtpFiltrarFecha.Value);
        }



    }

}
