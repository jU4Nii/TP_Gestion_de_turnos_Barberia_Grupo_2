using System;
using System.Windows.Forms;
using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;

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

            CargarTurnos();
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
            if (formAlta.ShowDialog() == DialogResult.OK)
            {
                CargarTurnos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTurnos.CurrentRow?.DataBoundItem is Turno turno)
            {
              
                FormAltaTurno formEditar = new FormAltaTurno(turno.Id);
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    CargarTurnos();
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
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormFiltradoPorPeluquero reporte = new FormFiltradoPorPeluquero();
            reporte.ShowDialog(); 
        }

       
    }

}
