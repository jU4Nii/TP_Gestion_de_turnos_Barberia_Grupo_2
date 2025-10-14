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
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 28);
            label2.Name = "label2";
            label2.Size = new Size(134, 50);
            label2.TabIndex = 3;
            label2.Text = "Turnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 91);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Turnos";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(60, 275);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar Turno";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(195, 275);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar Turno";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(354, 275);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar Turno";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewTurnos
            // 
            dataGridViewTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTurnos.Location = new Point(60, 109);
            dataGridViewTurnos.Name = "dataGridViewTurnos";
            dataGridViewTurnos.Size = new Size(430, 150);
            dataGridViewTurnos.TabIndex = 10;
            // 
            // FormListaTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 450);
            Controls.Add(dataGridViewTurnos);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
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
    }
}