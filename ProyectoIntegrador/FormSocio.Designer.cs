namespace ProyectoIntegrador
{
    partial class FrmSocio
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
            lblCarnetTitle = new System.Windows.Forms.Label();
            lblApellidoSocio = new System.Windows.Forms.Label();
            lblDniSocio = new System.Windows.Forms.Label();
            lblVencimientoTitle = new System.Windows.Forms.Label();
            lblVencimientoCuota = new System.Windows.Forms.Label();
            btnImprimirCarnet = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            lblNroCarnet = new System.Windows.Forms.Label();
            lblSocioNro = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblNombreSocio = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblCarnetTitle
            // 
            lblCarnetTitle.AutoSize = true;
            lblCarnetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCarnetTitle.Location = new System.Drawing.Point(85, 48);
            lblCarnetTitle.Name = "lblCarnetTitle";
            lblCarnetTitle.Size = new System.Drawing.Size(299, 33);
            lblCarnetTitle.TabIndex = 103;
            lblCarnetTitle.Text = "CARNET DE SOCIO";
            // 
            // lblApellidoSocio
            // 
            lblApellidoSocio.AutoSize = true;
            lblApellidoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblApellidoSocio.Location = new System.Drawing.Point(245, 137);
            lblApellidoSocio.Name = "lblApellidoSocio";
            lblApellidoSocio.Size = new System.Drawing.Size(110, 29);
            lblApellidoSocio.TabIndex = 105;
            lblApellidoSocio.Text = "Apellido";
            // 
            // lblDniSocio
            // 
            lblDniSocio.AutoSize = true;
            lblDniSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblDniSocio.Location = new System.Drawing.Point(278, 185);
            lblDniSocio.Name = "lblDniSocio";
            lblDniSocio.Size = new System.Drawing.Size(84, 29);
            lblDniSocio.TabIndex = 106;
            lblDniSocio.Text = "N° dni";
            // 
            // lblVencimientoTitle
            // 
            lblVencimientoTitle.AutoSize = true;
            lblVencimientoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblVencimientoTitle.Location = new System.Drawing.Point(156, 227);
            lblVencimientoTitle.Name = "lblVencimientoTitle";
            lblVencimientoTitle.Size = new System.Drawing.Size(163, 29);
            lblVencimientoTitle.TabIndex = 107;
            lblVencimientoTitle.Text = "Válido hasta:";
            // 
            // lblVencimientoCuota
            // 
            lblVencimientoCuota.AutoSize = true;
            lblVencimientoCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblVencimientoCuota.Location = new System.Drawing.Point(165, 256);
            lblVencimientoCuota.Name = "lblVencimientoCuota";
            lblVencimientoCuota.Size = new System.Drawing.Size(141, 29);
            lblVencimientoCuota.TabIndex = 108;
            lblVencimientoCuota.Text = "DD/MM/YY";
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnImprimirCarnet.Cursor = System.Windows.Forms.Cursors.Hand;
            btnImprimirCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImprimirCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnImprimirCarnet.ForeColor = System.Drawing.Color.White;
            btnImprimirCarnet.Location = new System.Drawing.Point(114, 303);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new System.Drawing.Size(110, 45);
            btnImprimirCarnet.TabIndex = 109;
            btnImprimirCarnet.Text = "IMPRIMIR";
            btnImprimirCarnet.UseVisualStyleBackColor = false;
            btnImprimirCarnet.Click += btnImprimirCarnet_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnVolver.ForeColor = System.Drawing.Color.White;
            btnVolver.Location = new System.Drawing.Point(245, 303);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(110, 45);
            btnVolver.TabIndex = 110;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNroCarnet
            // 
            lblNroCarnet.AutoSize = true;
            lblNroCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblNroCarnet.Location = new System.Drawing.Point(278, 96);
            lblNroCarnet.Name = "lblNroCarnet";
            lblNroCarnet.Size = new System.Drawing.Size(41, 29);
            lblNroCarnet.TabIndex = 111;
            lblNroCarnet.Text = "N°";
            // 
            // lblSocioNro
            // 
            lblSocioNro.AutoSize = true;
            lblSocioNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblSocioNro.Location = new System.Drawing.Point(114, 96);
            lblSocioNro.Name = "lblSocioNro";
            lblSocioNro.Size = new System.Drawing.Size(122, 29);
            lblSocioNro.TabIndex = 112;
            lblSocioNro.Text = "Socio N°:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(114, 185);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 29);
            label1.TabIndex = 113;
            label1.Text = "N° DNI:";
            // 
            // lblNombreSocio
            // 
            lblNombreSocio.AutoSize = true;
            lblNombreSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblNombreSocio.Location = new System.Drawing.Point(114, 137);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new System.Drawing.Size(107, 29);
            lblNombreSocio.TabIndex = 114;
            lblNombreSocio.Text = "Nombre";
            // 
            // FrmSocio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(460, 360);
            Controls.Add(lblNombreSocio);
            Controls.Add(label1);
            Controls.Add(lblSocioNro);
            Controls.Add(lblNroCarnet);
            Controls.Add(btnVolver);
            Controls.Add(btnImprimirCarnet);
            Controls.Add(lblVencimientoCuota);
            Controls.Add(lblVencimientoTitle);
            Controls.Add(lblDniSocio);
            Controls.Add(lblApellidoSocio);
            Controls.Add(lblCarnetTitle);
            Name = "FrmSocio";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormSocio";
            Controls.SetChildIndex(lblCarnetTitle, 0);
            Controls.SetChildIndex(lblApellidoSocio, 0);
            Controls.SetChildIndex(lblDniSocio, 0);
            Controls.SetChildIndex(lblVencimientoTitle, 0);
            Controls.SetChildIndex(lblVencimientoCuota, 0);
            Controls.SetChildIndex(btnImprimirCarnet, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(lblNroCarnet, 0);
            Controls.SetChildIndex(lblSocioNro, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(lblNombreSocio, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCarnetTitle;
        private System.Windows.Forms.Label lblApellidoSocio;
        private System.Windows.Forms.Label lblDniSocio;
        private System.Windows.Forms.Label lblVencimientoTitle;
        private System.Windows.Forms.Label lblVencimientoCuota;
        private System.Windows.Forms.Button btnImprimirCarnet;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNroCarnet;
        private System.Windows.Forms.Label lblSocioNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreSocio;
    }
}