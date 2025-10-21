using ClasesEjercicioPrueba.Models;
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
    public partial class FormAltaCliente : Form
    {
        private Cliente clienteEditando;

        public FormAltaCliente()
        {
            InitializeComponent();
        }

        
        public FormAltaCliente(int clienteId) : this()
        {
            clienteEditando = ClienteRepository.ObtenerPorId(clienteId);
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            if (clienteEditando != null)
            {
                
                txtNombre.Text = clienteEditando.Nombre;
                txtTelefono.Text = clienteEditando.Telefono;
                txtCorreo.Text = clienteEditando.Correo;
            }
            else
            {
                
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = ""; 
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text?.Trim() ?? "";



          
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe completar nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Debe completar teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


          
            var clientesExistentes = ClienteRepository.ObtenerTodos();
            bool clienteDuplicado = clientesExistentes.Any(c =>
                c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                (clienteEditando == null || c.Id != clienteEditando.Id) 
            );

            if (clienteDuplicado)
            {
                MessageBox.Show("Ya existe un cliente con ese nombre y apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clienteEditando != null)
            {
                
                clienteEditando.Nombre = nombre;
                clienteEditando.Telefono = telefono;
                clienteEditando.Correo = correo; 

                ClienteRepository.Actualizar(clienteEditando);
                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
               
                var nuevoCliente = new Cliente
                {
                    Nombre = nombre,
                    Telefono = telefono,
                    Correo = correo 
                };

                ClienteRepository.Agregar(nuevoCliente);
                MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
