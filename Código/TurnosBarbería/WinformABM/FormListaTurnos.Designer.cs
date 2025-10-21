namespace WinformABM
{
    partial class FormListaTurnos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dataGridViewTurnos = new DataGridView();
            btnReporte = new Button();
            btnAgregarCliente = new Button();
            btnEditarCliente = new Button();
            btnEliminarCliente = new Button();
            ListBoxListaClientes = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(405, 39);
            label2.Name = "label2";
            label2.Size = new Size(349, 62);
            label2.TabIndex = 3;
            label2.Text = "BarberManager";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 121);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Turnos";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(69, 367);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(147, 31);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar Turno";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(223, 367);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(175, 31);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar Turno";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(405, 367);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 31);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar Turno";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewTurnos
            // 
            dataGridViewTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTurnos.Location = new Point(69, 145);
            dataGridViewTurnos.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTurnos.Name = "dataGridViewTurnos";
            dataGridViewTurnos.RowHeadersWidth = 51;
            dataGridViewTurnos.Size = new Size(650, 200);
            dataGridViewTurnos.TabIndex = 10;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(171, 428);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(282, 29);
            btnReporte.TabIndex = 11;
            btnReporte.Text = "Ver listado de turnos por peluquero";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(821, 367);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(170, 29);
            btnAgregarCliente.TabIndex = 12;
            btnAgregarCliente.Text = "Añadir nuevo cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(918, 145);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(170, 29);
            btnEditarCliente.TabIndex = 13;
            btnEditarCliente.Text = "Editar cliente";
            btnEditarCliente.UseVisualStyleBackColor = true;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(742, 145);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(170, 29);
            btnEliminarCliente.TabIndex = 14;
            btnEliminarCliente.Text = "Eliminar cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // ListBoxListaClientes
            // 
            ListBoxListaClientes.FormattingEnabled = true;
            ListBoxListaClientes.Location = new Point(742, 180);
            ListBoxListaClientes.Name = "ListBoxListaClientes";
            ListBoxListaClientes.Size = new Size(350, 164);
            ListBoxListaClientes.TabIndex = 15;
            // 
            // FormListaTurnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 600);
            Controls.Add(ListBoxListaClientes);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(btnReporte);
            Controls.Add(dataGridViewTurnos);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormListaTurnos";
            Text = "BajaModificacion";
            Load += FormListaTurnos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dataGridViewTurnos;
        private Button btnReporte;
        private Button btnAgregarCliente;
        private Button btnEditarCliente;
        private Button btnEliminarCliente;
        private ListBox ListBoxListaClientes;
    }
}