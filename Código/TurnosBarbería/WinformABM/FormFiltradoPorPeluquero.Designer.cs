namespace WinformABM
{
    partial class FormFiltradoPorPeluquero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxPeluquero = new ComboBox();
            label1 = new Label();
            dataGridViewTurnos = new DataGridView();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPeluquero
            // 
            comboBoxPeluquero.FormattingEnabled = true;
            comboBoxPeluquero.Location = new Point(133, 107);
            comboBoxPeluquero.Name = "comboBoxPeluquero";
            comboBoxPeluquero.Size = new Size(151, 28);
            comboBoxPeluquero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 84);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione peluquero:";
            // 
            // dataGridViewTurnos
            // 
            dataGridViewTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTurnos.Location = new Point(133, 141);
            dataGridViewTurnos.Name = "dataGridViewTurnos";
            dataGridViewTurnos.RowHeadersWidth = 51;
            dataGridViewTurnos.Size = new Size(300, 188);
            dataGridViewTurnos.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(133, 335);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // FormFiltradoPorPeluquero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 516);
            Controls.Add(btnFiltrar);
            Controls.Add(dataGridViewTurnos);
            Controls.Add(label1);
            Controls.Add(comboBoxPeluquero);
            Name = "FormFiltradoPorPeluquero";
            Text = "FormFiltradoPorPeluquero";
            Load += FormFiltradoPorPeluquero_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPeluquero;
        private Label label1;
        private DataGridView dataGridViewTurnos;
        private Button btnFiltrar;
    }
}