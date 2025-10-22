namespace WinformABM
{
    partial class FormAltaTurno
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
            btnAgregar = new Button();
            listaClientes = new ComboBox();
            listaServicios = new ComboBox();
            listaPeluqueros = new ComboBox();
            dateTimePickerFecha = new DateTimePicker();
            dateTimePickerHora = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 47);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(118, 111);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(55, 20);
            Cliente.TabIndex = 3;
            Cliente.Text = "Cliente";
            // 
            // nuevoturno
            // 
            nuevoturno.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nuevoturno.Location = new Point(342, 24);
            nuevoturno.Name = "nuevoturno";
            nuevoturno.Size = new Size(241, 67);
            nuevoturno.TabIndex = 5;
            nuevoturno.Text = "Nuevo Turno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 196);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 9;
            label2.Text = "Servicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 301);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Peluquero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 412);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 11;
            label5.Text = "Fecha";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(699, 516);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 27);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // listaClientes
            // 
            listaClientes.FormattingEnabled = true;
            listaClientes.Location = new Point(118, 135);
            listaClientes.Margin = new Padding(3, 4, 3, 4);
            listaClientes.Name = "listaClientes";
            listaClientes.Size = new Size(612, 28);
            listaClientes.TabIndex = 27;
            // 
            // listaServicios
            // 
            listaServicios.FormattingEnabled = true;
            listaServicios.Location = new Point(118, 220);
            listaServicios.Margin = new Padding(3, 4, 3, 4);
            listaServicios.Name = "listaServicios";
            listaServicios.Size = new Size(233, 28);
            listaServicios.TabIndex = 28;
            // 
            // listaPeluqueros
            // 
            listaPeluqueros.FormattingEnabled = true;
            listaPeluqueros.Location = new Point(118, 325);
            listaPeluqueros.Margin = new Padding(3, 4, 3, 4);
            listaPeluqueros.Name = "listaPeluqueros";
            listaPeluqueros.Size = new Size(233, 28);
            listaPeluqueros.TabIndex = 29;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(118, 436);
            dateTimePickerFecha.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(265, 27);
            dateTimePickerFecha.TabIndex = 30;
            // 
            // dateTimePickerHora
            // 
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.Location = new Point(435, 436);
            dateTimePickerHora.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerHora.Name = "dateTimePickerHora";
            dateTimePickerHora.ShowUpDown = true;
            dateTimePickerHora.Size = new Size(265, 27);
            dateTimePickerHora.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 412);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 32;
            label3.Text = "Hora";
            // 
            // FormAltaTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 613);
            Controls.Add(label3);
            Controls.Add(dateTimePickerHora);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(listaPeluqueros);
            Controls.Add(listaServicios);
            Controls.Add(listaClientes);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(nuevoturno);
            Controls.Add(Cliente);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAltaTurno";
            Text = "Form1";
            Load += FormAltaTurno_Load;
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
        private Button btnAgregar;
        private ComboBox listaClientes;
        private ComboBox listaServicios;
        private ComboBox listaPeluqueros;
        private DateTimePicker dateTimePickerFecha;
        private DateTimePicker dateTimePickerHora;
        private Label label3;
    }
}
