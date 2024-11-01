namespace ProyectoIntegrador
{
    partial class FrmEmitirCarnet
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
            lblEmitirCarnetTitle = new System.Windows.Forms.Label();
            lblDniTitle = new System.Windows.Forms.Label();
            txtDni = new System.Windows.Forms.TextBox();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblEmitirCarnetTitle
            // 
            lblEmitirCarnetTitle.AutoSize = true;
            lblEmitirCarnetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            lblEmitirCarnetTitle.Location = new System.Drawing.Point(78, 61);
            lblEmitirCarnetTitle.Name = "lblEmitirCarnetTitle";
            lblEmitirCarnetTitle.Size = new System.Drawing.Size(298, 39);
            lblEmitirCarnetTitle.TabIndex = 103;
            lblEmitirCarnetTitle.Text = "EMITIR CARNET";
            // 
            // lblDniTitle
            // 
            lblDniTitle.AutoSize = true;
            lblDniTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDniTitle.Location = new System.Drawing.Point(184, 132);
            lblDniTitle.Name = "lblDniTitle";
            lblDniTitle.Size = new System.Drawing.Size(75, 37);
            lblDniTitle.TabIndex = 104;
            lblDniTitle.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new System.Drawing.Point(152, 185);
            txtDni.MaxLength = 10;
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "33016244";
            txtDni.Size = new System.Drawing.Size(136, 23);
            txtDni.TabIndex = 105;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            btnAceptar.ForeColor = System.Drawing.Color.White;
            btnAceptar.Location = new System.Drawing.Point(104, 239);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(100, 40);
            btnAceptar.TabIndex = 106;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Location = new System.Drawing.Point(229, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 40);
            btnCancelar.TabIndex = 107;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmEmitirCarnet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 320);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDni);
            Controls.Add(lblDniTitle);
            Controls.Add(lblEmitirCarnetTitle);
            ForeColor = System.Drawing.Color.Black;
            Name = "FrmEmitirCarnet";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormEmitirCarnet";
            Controls.SetChildIndex(lblEmitirCarnetTitle, 0);
            Controls.SetChildIndex(lblDniTitle, 0);
            Controls.SetChildIndex(txtDni, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEmitirCarnetTitle;
        private System.Windows.Forms.Label lblDniTitle;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}