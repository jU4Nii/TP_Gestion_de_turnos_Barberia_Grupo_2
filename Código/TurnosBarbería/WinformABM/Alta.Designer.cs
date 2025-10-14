namespace WinformABM
{
    partial class Alta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Cliente = new Label();
            nuevoturno = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listaServicios = new DataGridView();
            btnCancelar = new Button();
            btnAgregar = new Button();
            listaClientes = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            listaServicio = new DataGridView();
            listaPeluqueros = new DataGridView();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)listaServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaPeluqueros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(103, 83);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(44, 15);
            Cliente.TabIndex = 3;
            Cliente.Text = "Cliente";
            // 
            // nuevoturno
            // 
            nuevoturno.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nuevoturno.Location = new Point(303, 25);
            nuevoturno.Name = "nuevoturno";
            nuevoturno.Size = new Size(185, 50);
            nuevoturno.TabIndex = 5;
            nuevoturno.Text = "Nuevo Turno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 147);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 9;
            label2.Text = "Servicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 226);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 10;
            label4.Text = "Peluquero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 309);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "Fecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(419, 309);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 12;
            label6.Text = "Hora";
            // 
            // listaServicios
            // 
            listaServicios.BackgroundColor = SystemColors.ButtonHighlight;
            listaServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaServicios.Location = new Point(103, 165);
            listaServicios.Name = "listaServicios";
            listaServicios.Size = new Size(204, 25);
            listaServicios.TabIndex = 13;
            listaServicios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(482, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 20);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(612, 387);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 20);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_Click;
            // 
            // listaClientes
            // 
            listaClientes.BackgroundColor = SystemColors.ButtonHighlight;
            listaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaClientes.Location = new Point(103, 101);
            listaClientes.Name = "listaClientes";
            listaClientes.Size = new Size(557, 25);
            listaClientes.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 327);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(419, 327);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 22;
            dateTimePicker2.Value = new DateTime(2025, 10, 14, 16, 56, 0, 0);
            // 
            // listaServicio
            // 
            listaServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaServicio.Location = new Point(103, 185);
            listaServicio.Name = "listaServicio";
            listaServicio.Size = new Size(204, 25);
            listaServicio.TabIndex = 23;
            // 
            // listaPeluqueros
            // 
            listaPeluqueros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaPeluqueros.Location = new Point(103, 264);
            listaPeluqueros.Name = "listaPeluqueros";
            listaPeluqueros.Size = new Size(204, 25);
            listaPeluqueros.TabIndex = 25;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(103, 244);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(204, 25);
            dataGridView3.TabIndex = 24;
            // 
            // Alta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 450);
            Controls.Add(listaPeluqueros);
            Controls.Add(dataGridView3);
            Controls.Add(listaServicio);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(listaClientes);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(listaServicios);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(nuevoturno);
            Controls.Add(Cliente);
            Controls.Add(label1);
            Name = "Alta";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)listaServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaServicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaPeluqueros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label Cliente;
        private Label nuevoturno;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView listaServicios;
        private Button btnCancelar;
        private Button btnAgregar;
        private DataGridView listaClientes;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView listaServicio;
        private DataGridView listaPeluqueros;
        private DataGridView dataGridView3;
    }
}
