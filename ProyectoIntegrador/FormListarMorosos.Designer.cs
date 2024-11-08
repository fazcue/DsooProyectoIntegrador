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
            btnVolver = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            lblMensajeAlDia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtgvMorosos).BeginInit();
            SuspendLayout();
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Location = new System.Drawing.Point(110, 11);
            lblSubtitulo.Size = new System.Drawing.Size(268, 37);
            lblSubtitulo.Text = "Listado Morosos";
            // 
            // dtgvMorosos
            // 
            dtgvMorosos.AllowUserToAddRows = false;
            dtgvMorosos.AllowUserToDeleteRows = false;
            dtgvMorosos.AllowUserToOrderColumns = true;
            dtgvMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMorosos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { nombre, apellido, dni, fechaVencimientoCuota });
            dtgvMorosos.Location = new System.Drawing.Point(23, 105);
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
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnVolver.ForeColor = System.Drawing.Color.White;
            btnVolver.Location = new System.Drawing.Point(261, 277);
            btnVolver.Margin = new System.Windows.Forms.Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(126, 40);
            btnVolver.TabIndex = 105;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = System.Drawing.Color.White;
            btnActualizar.Location = new System.Drawing.Point(101, 277);
            btnActualizar.Margin = new System.Windows.Forms.Padding(0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(126, 40);
            btnActualizar.TabIndex = 106;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblMensajeAlDia
            // 
            lblMensajeAlDia.AutoSize = true;
            lblMensajeAlDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMensajeAlDia.Location = new System.Drawing.Point(151, 151);
            lblMensajeAlDia.Margin = new System.Windows.Forms.Padding(0);
            lblMensajeAlDia.Name = "lblMensajeAlDia";
            lblMensajeAlDia.Size = new System.Drawing.Size(186, 33);
            lblMensajeAlDia.TabIndex = 107;
            lblMensajeAlDia.Text = "Todos al día";
            lblMensajeAlDia.Visible = false;
            // 
            // FrmListarMorosos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(489, 327);
            Controls.Add(lblMensajeAlDia);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolver);
            Controls.Add(dtgvMorosos);
            Name = "FrmListarMorosos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormListarMorosos";
            Load += Loading;
            Controls.SetChildIndex(dtgvMorosos, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(btnActualizar, 0);
            Controls.SetChildIndex(lblMensajeAlDia, 0);
            ((System.ComponentModel.ISupportInitialize)dtgvMorosos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMorosos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoCuota;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblMensajeAlDia;
    }
}