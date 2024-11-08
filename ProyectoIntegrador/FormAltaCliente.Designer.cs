namespace ProyectoIntegrador
{
    partial class FrmAltaCliente
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
            txtNombre = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            lblDni = new System.Windows.Forms.Label();
            txtDni = new System.Windows.Forms.TextBox();
            btnRegistrar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            cboTipo = new System.Windows.Forms.ComboBox();
            lblTipo = new System.Windows.Forms.Label();
            checkAptoFisico = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Location = new System.Drawing.Point(119, 11);
            lblSubtitulo.Size = new System.Drawing.Size(192, 37);
            lblSubtitulo.Text = "Alta Cliente";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(22, 186);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej: Jose";
            txtNombre.Size = new System.Drawing.Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNombre.Location = new System.Drawing.Point(22, 166);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(50, 13);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblApellido.Location = new System.Drawing.Point(154, 166);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(52, 13);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(154, 186);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ej: Martinez";
            txtApellido.Size = new System.Drawing.Size(100, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDni.Location = new System.Drawing.Point(154, 101);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(29, 13);
            lblDni.TabIndex = 8;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new System.Drawing.Point(154, 124);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ej: 39342911";
            txtDni.Size = new System.Drawing.Size(100, 23);
            txtDni.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = System.Drawing.Color.White;
            btnRegistrar.Location = new System.Drawing.Point(277, 124);
            btnRegistrar.Margin = new System.Windows.Forms.Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(130, 185);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = System.Drawing.Color.White;
            btnLimpiar.Location = new System.Drawing.Point(22, 269);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(100, 40);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Location = new System.Drawing.Point(154, 269);
            btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Socio", "No socio" });
            cboTipo.Location = new System.Drawing.Point(22, 124);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new System.Drawing.Size(100, 23);
            cboTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTipo.Location = new System.Drawing.Point(22, 101);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(32, 13);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // checkAptoFisico
            // 
            checkAptoFisico.AutoSize = true;
            checkAptoFisico.Cursor = System.Windows.Forms.Cursors.Hand;
            checkAptoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkAptoFisico.Location = new System.Drawing.Point(26, 228);
            checkAptoFisico.Name = "checkAptoFisico";
            checkAptoFisico.Size = new System.Drawing.Size(139, 24);
            checkAptoFisico.TabIndex = 103;
            checkAptoFisico.Text = "APTO FÍSICO";
            checkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // FrmAltaCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(431, 320);
            Controls.Add(checkAptoFisico);
            Controls.Add(lblTipo);
            Controls.Add(cboTipo);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            MaximizeBox = false;
            Name = "FrmAltaCliente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Alta Cliente - Club Deportivo";
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(lblApellido, 0);
            Controls.SetChildIndex(txtDni, 0);
            Controls.SetChildIndex(lblDni, 0);
            Controls.SetChildIndex(btnRegistrar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(cboTipo, 0);
            Controls.SetChildIndex(lblTipo, 0);
            Controls.SetChildIndex(checkAptoFisico, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox checkAptoFisico;
    }
}