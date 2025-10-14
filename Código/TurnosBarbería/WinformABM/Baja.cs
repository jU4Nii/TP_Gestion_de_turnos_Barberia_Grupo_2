using System;
using System.Windows.Forms;
using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;

namespace WinformABM
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
            CargarTurnos();
        }

        private void CargarTurnos()
        {
            // Carga todos los turnos en el grid
            listaTurnos.DataSource = TurnoRepository.ObtenerTodos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaTurnos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un turno para eliminar.");
                return;
            }

            var turno = listaTurnos.CurrentRow.DataBoundItem as Turno;
            if (turno != null)
            {
                TurnoRepository.Eliminar(turno.Id);
                MessageBox.Show("Turno eliminado correctamente.");
                CargarTurnos();
            }
        }

        private void listaTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes mostrar detalles del turno si lo necesitas
        }
    }
}
