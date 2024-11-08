﻿namespace ProyectoIntegrador
{
    partial class FrmLogin
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
            lblUsuario = new System.Windows.Forms.Label();
            lblClave = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtClave = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.Button();
            pcbMessi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMessi).BeginInit();
            SuspendLayout();
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSubtitulo.Location = new System.Drawing.Point(0, 23);
            lblSubtitulo.Size = new System.Drawing.Size(184, 37);
            lblSubtitulo.Text = "GRUPO 10";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblUsuario.Location = new System.Drawing.Point(11, 103);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(50, 13);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblClave.Location = new System.Drawing.Point(11, 155);
            lblClave.Name = "lblClave";
            lblClave.Size = new System.Drawing.Size(71, 13);
            lblClave.TabIndex = 4;
            lblClave.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(11, 121);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ej: Jose";
            txtUsuario.Size = new System.Drawing.Size(134, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.Location = new System.Drawing.Point(11, 173);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Ej: argentina2024";
            txtClave.Size = new System.Drawing.Size(134, 23);
            txtClave.TabIndex = 1;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = System.Drawing.Color.White;
            btnIngresar.Location = new System.Drawing.Point(11, 209);
            btnIngresar.Margin = new System.Windows.Forms.Padding(0);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(134, 40);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pcbMessi
            // 
            pcbMessi.BackColor = System.Drawing.Color.Transparent;
            pcbMessi.Image = Properties.Resources.messi;
            pcbMessi.Location = new System.Drawing.Point(173, 30);
            pcbMessi.Name = "pcbMessi";
            pcbMessi.Size = new System.Drawing.Size(263, 246);
            pcbMessi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pcbMessi.TabIndex = 7;
            pcbMessi.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(403, 260);
            Controls.Add(pcbMessi);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login - Club Deportivo";
            Controls.SetChildIndex(lblUsuario, 0);
            Controls.SetChildIndex(lblClave, 0);
            Controls.SetChildIndex(txtUsuario, 0);
            Controls.SetChildIndex(txtClave, 0);
            Controls.SetChildIndex(btnIngresar, 0);
            Controls.SetChildIndex(pcbMessi, 0);
            ((System.ComponentModel.ISupportInitialize)pcbMessi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pcbMessi;
    }
}