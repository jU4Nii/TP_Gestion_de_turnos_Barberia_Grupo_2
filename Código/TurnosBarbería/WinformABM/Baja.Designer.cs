namespace WinformABM
{
    partial class Baja
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
            txtBuscar = new TextBox();
            listaTurnos = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)listaTurnos).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.ControlLightLight;
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Location = new Point(60, 109);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(739, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.Text = "Buscar turnos...";
            // 
            // listaTurnos
            // 
            listaTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaTurnos.Location = new Point(60, 119);
            listaTurnos.Name = "listaTurnos";
            listaTurnos.Size = new Size(739, 25);
            listaTurnos.TabIndex = 2;
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
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Turnos";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(643, 160);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(724, 160);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Baja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtBuscar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listaTurnos);
            Name = "Baja";
            Text = "BajaModificacion";
            ((System.ComponentModel.ISupportInitialize)listaTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscar;
        private DataGridView listaTurnos;
        private Label label2;
        private Label label3;
        private Button btnModificar;
        private Button btnEliminar;
    }
}