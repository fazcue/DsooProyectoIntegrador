namespace ProyectoIntegrador
{
    partial class FrmMenuPrincipal
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
            btnAltaCliente = new System.Windows.Forms.Button();
            btnListarMorosos = new System.Windows.Forms.Button();
            btnPagarCuota = new System.Windows.Forms.Button();
            btnEmitirCarnet = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Location = new System.Drawing.Point(75, 11);
            lblSubtitulo.Size = new System.Drawing.Size(242, 37);
            lblSubtitulo.Text = "Menú Principal";
            // 
            // btnAltaCliente
            // 
            btnAltaCliente.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnAltaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAltaCliente.FlatAppearance.BorderSize = 0;
            btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAltaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAltaCliente.ForeColor = System.Drawing.Color.White;
            btnAltaCliente.Location = new System.Drawing.Point(38, 117);
            btnAltaCliente.Margin = new System.Windows.Forms.Padding(0);
            btnAltaCliente.Name = "btnAltaCliente";
            btnAltaCliente.Size = new System.Drawing.Size(134, 40);
            btnAltaCliente.TabIndex = 0;
            btnAltaCliente.Text = "ALTA CLIENTE";
            btnAltaCliente.UseVisualStyleBackColor = false;
            btnAltaCliente.Click += btnAltaCliente_Click;
            // 
            // btnListarMorosos
            // 
            btnListarMorosos.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnListarMorosos.Cursor = System.Windows.Forms.Cursors.Hand;
            btnListarMorosos.FlatAppearance.BorderSize = 0;
            btnListarMorosos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnListarMorosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnListarMorosos.ForeColor = System.Drawing.Color.White;
            btnListarMorosos.Location = new System.Drawing.Point(38, 171);
            btnListarMorosos.Margin = new System.Windows.Forms.Padding(0);
            btnListarMorosos.Name = "btnListarMorosos";
            btnListarMorosos.Size = new System.Drawing.Size(134, 40);
            btnListarMorosos.TabIndex = 2;
            btnListarMorosos.Text = "LISTAR MOROSOS";
            btnListarMorosos.UseVisualStyleBackColor = false;
            btnListarMorosos.Click += btnListarMorosos_Click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnPagarCuota.Enabled = false;
            btnPagarCuota.FlatAppearance.BorderSize = 0;
            btnPagarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPagarCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPagarCuota.ForeColor = System.Drawing.Color.White;
            btnPagarCuota.Location = new System.Drawing.Point(220, 117);
            btnPagarCuota.Margin = new System.Windows.Forms.Padding(0);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new System.Drawing.Size(134, 40);
            btnPagarCuota.TabIndex = 1;
            btnPagarCuota.Text = "PAGAR CUOTA";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnEmitirCarnet.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEmitirCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEmitirCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            btnEmitirCarnet.ForeColor = System.Drawing.Color.White;
            btnEmitirCarnet.Location = new System.Drawing.Point(220, 171);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new System.Drawing.Size(134, 40);
            btnEmitirCarnet.TabIndex = 103;
            btnEmitirCarnet.Text = "EMITIR CARNET";
            btnEmitirCarnet.UseMnemonic = false;
            btnEmitirCarnet.UseVisualStyleBackColor = false;
            btnEmitirCarnet.Click += btnEmitirCarnet_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(392, 235);
            Controls.Add(btnEmitirCarnet);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnListarMorosos);
            Controls.Add(btnAltaCliente);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Menu Principal - Club Deportivo";
            Controls.SetChildIndex(btnAltaCliente, 0);
            Controls.SetChildIndex(btnListarMorosos, 0);
            Controls.SetChildIndex(btnPagarCuota, 0);
            Controls.SetChildIndex(btnEmitirCarnet, 0);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnListarMorosos;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Button btnEmitirCarnet;
    }
}