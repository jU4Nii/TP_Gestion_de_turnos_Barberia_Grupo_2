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
            AgregarColumnasBotones();
            CargarTurnos();
        }

        private void AgregarColumnasBotones()
        {
            // Evita duplicar columnas si ya existen
            if (listaTurnos.Columns["Modificar"] == null)
            {
                var btnModificar = new DataGridViewButtonColumn
                {
                    Name = "Modificar",
                    HeaderText = "Modificar",
                    Text = "Modificar",
                    UseColumnTextForButtonValue = true
                };
                listaTurnos.Columns.Add(btnModificar);
            }

            if (listaTurnos.Columns["Eliminar"] == null)
            {
                var btnEliminar = new DataGridViewButtonColumn
                {
                    Name = "Eliminar",
                    HeaderText = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                listaTurnos.Columns.Add(btnEliminar);
            }
        }

        private void CargarTurnos()
        {
            listaTurnos.DataSource = null;
            listaTurnos.DataSource = TurnoRepository.ObtenerTodos();
        }

        private void listaTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var turno = listaTurnos.Rows[e.RowIndex].DataBoundItem as Turno;
            if (turno == null) return;

            if (listaTurnos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                TurnoRepository.Eliminar(turno.Id);
                MessageBox.Show("Turno eliminado correctamente.");
                CargarTurnos();
            }
            else if (listaTurnos.Columns[e.ColumnIndex].Name == "Modificar")
            {
                // Aquí puedes abrir un formulario de edición, por ejemplo:
                var formModificar = new FormAltaTurno(turno); // Suponiendo que tienes un formulario Alta que acepta un turno
                if (formModificar.ShowDialog() == DialogResult.OK)
                {
                    CargarTurnos();
                }
            }
        }

       
    }
}
