using ClasesEjercicioPrueba.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformABM
{
    public partial class FormFiltradoPorPeluquero : Form
    {
        public FormFiltradoPorPeluquero()
        {
            InitializeComponent();
        }

        private void FormFiltradoPorPeluquero_Load(object sender, EventArgs e)
        {
            comboBoxPeluquero.DataSource = PeluqueroRepository.ObtenerTodos();
            comboBoxPeluquero.DisplayMember = "Nombre";
            comboBoxPeluquero.ValueMember = "Id";
            comboBoxPeluquero.SelectedIndex = -1;

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
                HeaderText = "Fecha",
                DataPropertyName = "Fecha"
            });
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (comboBoxPeluquero.SelectedValue is int peluqueroId)
            {
                var turnos = TurnoRepository.ObtenerPorPeluqueroId(peluqueroId);
                dataGridViewTurnos.DataSource = null;
                dataGridViewTurnos.DataSource = turnos;
            }
            else
            {
                MessageBox.Show("Seleccione un peluquero.");
            }
        }

    }
}
