namespace ProyectoIntegrador
{
    partial class FrmListarMorosos
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
            dtgvMorosos = new System.Windows.Forms.DataGridView();
            nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fechaVencimientoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvMorosos).BeginInit();
            SuspendLayout();
            // 
            // dtgvMorosos
            // 
            dtgvMorosos.AllowUserToAddRows = false;
            dtgvMorosos.AllowUserToDeleteRows = false;
            dtgvMorosos.AllowUserToOrderColumns = true;
            dtgvMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMorosos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { nombre, apellido, dni, fechaVencimientoCuota });
            dtgvMorosos.Location = new System.Drawing.Point(71, 135);
            dtgvMorosos.Name = "dtgvMorosos";
            dtgvMorosos.ReadOnly = true;
            dtgvMorosos.Size = new System.Drawing.Size(443, 161);
            dtgvMorosos.TabIndex = 103;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // fechaVencimientoCuota
            // 
            fechaVencimientoCuota.HeaderText = "Fecha Vencimiento";
            fechaVencimientoCuota.Name = "fechaVencimientoCuota";
            fechaVencimientoCuota.ReadOnly = true;
            // 
            // FrmListarMorosos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(586, 403);
            Controls.Add(dtgvMorosos);
            Name = "FrmListarMorosos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormListarMorosos";
            Load += Loading;
            Controls.SetChildIndex(dtgvMorosos, 0);
            ((System.ComponentModel.ISupportInitialize)dtgvMorosos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMorosos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoCuota;
    }
}