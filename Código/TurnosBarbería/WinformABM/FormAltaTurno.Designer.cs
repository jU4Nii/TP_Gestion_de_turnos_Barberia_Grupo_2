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
            btnCancelar = new Button();
            btnAgregar = new Button();
            comboBox1 = new ComboBox();
            comboCliente = new ComboBox();
            comboServicio = new ComboBox();
            comboPeluquero = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(518, 192);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            // 
            // comboCliente
            // 
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(103, 101);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(536, 23);
            comboCliente.TabIndex = 27;
            // 
            // comboServicio
            // 
            comboServicio.FormattingEnabled = true;
            comboServicio.Location = new Point(103, 165);
            comboServicio.Name = "comboServicio";
            comboServicio.Size = new Size(204, 23);
            comboServicio.TabIndex = 28;
            // 
            // comboPeluquero
            // 
            comboPeluquero.FormattingEnabled = true;
            comboPeluquero.Location = new Point(103, 244);
            comboPeluquero.Name = "comboPeluquero";
            comboPeluquero.Size = new Size(204, 23);
            comboPeluquero.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 327);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // FormAltaTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboPeluquero);
            Controls.Add(comboServicio);
            Controls.Add(comboCliente);
            Controls.Add(comboBox1);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(nuevoturno);
            Controls.Add(Cliente);
            Controls.Add(label1);
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
        private Button btnCancelar;
        private Button btnAgregar;
        private ComboBox comboBox1;
        private ComboBox comboCliente;
        private ComboBox comboServicio;
        private ComboBox comboPeluquero;
        private DateTimePicker dateTimePicker1;
    }
}
