namespace ProyectoIntegrador
{
    partial class FrmPagarCuota
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            btnBuscar = new System.Windows.Forms.Button();
            lblDni = new System.Windows.Forms.Label();
            txtDni = new System.Windows.Forms.TextBox();
            lblTipo = new System.Windows.Forms.Label();
            cboTipo = new System.Windows.Forms.ComboBox();
            cboCuotas = new System.Windows.Forms.ComboBox();
            cboFormaPago = new System.Windows.Forms.ComboBox();
            lblVencimientoCliente = new System.Windows.Forms.Label();
            lblVencimiento = new System.Windows.Forms.Label();
            lblCuotas = new System.Windows.Forms.Label();
            lblFormaPago = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnPagar = new System.Windows.Forms.Button();
            lblMontoCliente = new System.Windows.Forms.Label();
            lblMonto = new System.Windows.Forms.Label();
            lblApellidoCliente = new System.Windows.Forms.Label();
            lblNombreCliente = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Location = new System.Drawing.Point(117, 11);
            lblSubtitulo.Size = new System.Drawing.Size(209, 37);
            lblSubtitulo.Text = "Pagar Cuota";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 90);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = System.Drawing.Color.Cornsilk;
            splitContainer1.Panel1.Controls.Add(btnBuscar);
            splitContainer1.Panel1.Controls.Add(lblDni);
            splitContainer1.Panel1.Controls.Add(txtDni);
            splitContainer1.Panel1.Controls.Add(lblTipo);
            splitContainer1.Panel1.Controls.Add(cboTipo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = System.Drawing.Color.LightYellow;
            splitContainer1.Panel2.Controls.Add(cboCuotas);
            splitContainer1.Panel2.Controls.Add(cboFormaPago);
            splitContainer1.Panel2.Controls.Add(lblVencimientoCliente);
            splitContainer1.Panel2.Controls.Add(lblVencimiento);
            splitContainer1.Panel2.Controls.Add(lblCuotas);
            splitContainer1.Panel2.Controls.Add(lblFormaPago);
            splitContainer1.Panel2.Controls.Add(btnCancelar);
            splitContainer1.Panel2.Controls.Add(btnPagar);
            splitContainer1.Panel2.Controls.Add(lblMontoCliente);
            splitContainer1.Panel2.Controls.Add(lblMonto);
            splitContainer1.Panel2.Controls.Add(lblApellidoCliente);
            splitContainer1.Panel2.Controls.Add(lblNombreCliente);
            splitContainer1.Panel2.Controls.Add(lblApellido);
            splitContainer1.Panel2.Controls.Add(lblNombre);
            splitContainer1.Size = new System.Drawing.Size(444, 202);
            splitContainer1.SplitterDistance = 147;
            splitContainer1.TabIndex = 104;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = System.Drawing.Color.White;
            btnBuscar.Location = new System.Drawing.Point(23, 143);
            btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(100, 40);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDni.Location = new System.Drawing.Point(23, 77);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(29, 13);
            lblDni.TabIndex = 11;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new System.Drawing.Point(23, 100);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ej: 39342911";
            txtDni.Size = new System.Drawing.Size(100, 23);
            txtDni.TabIndex = 10;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTipo.Location = new System.Drawing.Point(23, 18);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(32, 13);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Socio", "No socio" });
            cboTipo.Location = new System.Drawing.Point(23, 41);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new System.Drawing.Size(100, 23);
            cboTipo.TabIndex = 8;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCuotas.Enabled = false;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1 cuota", "3 cuotas" });
            cboCuotas.Location = new System.Drawing.Point(164, 72);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new System.Drawing.Size(100, 23);
            cboCuotas.TabIndex = 21;
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFormaPago.Enabled = false;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cboFormaPago.Location = new System.Drawing.Point(164, 31);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new System.Drawing.Size(100, 23);
            cboFormaPago.TabIndex = 13;
            cboFormaPago.SelectedIndexChanged += cboFormaPago_SelectedIndexChanged;
            // 
            // lblVencimientoCliente
            // 
            lblVencimientoCliente.AutoSize = true;
            lblVencimientoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblVencimientoCliente.Location = new System.Drawing.Point(29, 113);
            lblVencimientoCliente.Name = "lblVencimientoCliente";
            lblVencimientoCliente.Size = new System.Drawing.Size(99, 20);
            lblVencimientoCliente.TabIndex = 20;
            lblVencimientoCliente.Text = "__________";
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblVencimiento.Location = new System.Drawing.Point(29, 102);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new System.Drawing.Size(80, 13);
            lblVencimiento.TabIndex = 19;
            lblVencimiento.Text = "Vencimiento:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCuotas.Location = new System.Drawing.Point(164, 58);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new System.Drawing.Size(50, 13);
            lblCuotas.TabIndex = 18;
            lblCuotas.Text = "Cuotas:";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFormaPago.Location = new System.Drawing.Point(164, 16);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new System.Drawing.Size(77, 13);
            lblFormaPago.TabIndex = 17;
            lblFormaPago.Text = "Forma pago:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Location = new System.Drawing.Point(164, 144);
            btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 40);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPagar.Enabled = false;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPagar.ForeColor = System.Drawing.Color.White;
            btnPagar.Location = new System.Drawing.Point(32, 144);
            btnPagar.Margin = new System.Windows.Forms.Padding(0);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new System.Drawing.Size(100, 40);
            btnPagar.TabIndex = 13;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblMontoCliente
            // 
            lblMontoCliente.AutoSize = true;
            lblMontoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMontoCliente.Location = new System.Drawing.Point(164, 113);
            lblMontoCliente.Name = "lblMontoCliente";
            lblMontoCliente.Size = new System.Drawing.Size(99, 20);
            lblMontoCliente.TabIndex = 15;
            lblMontoCliente.Text = "__________";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMonto.Location = new System.Drawing.Point(164, 102);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new System.Drawing.Size(46, 13);
            lblMonto.TabIndex = 14;
            lblMonto.Text = "Monto:";
            // 
            // lblApellidoCliente
            // 
            lblApellidoCliente.AutoSize = true;
            lblApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblApellidoCliente.Location = new System.Drawing.Point(29, 73);
            lblApellidoCliente.Name = "lblApellidoCliente";
            lblApellidoCliente.Size = new System.Drawing.Size(99, 20);
            lblApellidoCliente.TabIndex = 13;
            lblApellidoCliente.Text = "__________";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNombreCliente.Location = new System.Drawing.Point(29, 31);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new System.Drawing.Size(99, 20);
            lblNombreCliente.TabIndex = 12;
            lblNombreCliente.Text = "__________";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblApellido.Location = new System.Drawing.Point(29, 60);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(56, 13);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNombre.Location = new System.Drawing.Point(29, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(54, 13);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // FrmPagarCuota
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(444, 292);
            Controls.Add(splitContainer1);
            Name = "FrmPagarCuota";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormPagarCuota";
            Controls.SetChildIndex(splitContainer1, 0);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblMontoCliente;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblVencimientoCliente;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.ComboBox cboFormaPago;
    }
}