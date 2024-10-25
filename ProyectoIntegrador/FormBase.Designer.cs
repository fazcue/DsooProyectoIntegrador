namespace ProyectoIntegrador
{
    partial class FrmBase
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            btnAcerca = new System.Windows.Forms.Button();
            btnCerrar = new System.Windows.Forms.Button();
            lblTitulo = new System.Windows.Forms.Label();
            tlpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // tlpMenu
            // 
            tlpMenu.BackColor = System.Drawing.Color.LightYellow;
            tlpMenu.ColumnCount = 3;
            tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpMenu.Controls.Add(btnAcerca, 1, 0);
            tlpMenu.Controls.Add(btnCerrar, 2, 0);
            tlpMenu.Controls.Add(lblTitulo, 0, 0);
            tlpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            tlpMenu.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            tlpMenu.Location = new System.Drawing.Point(0, 0);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 1;
            tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMenu.Size = new System.Drawing.Size(405, 30);
            tlpMenu.TabIndex = 102;
            tlpMenu.MouseDown += mouse_down;
            tlpMenu.MouseMove += mouse_move;
            // 
            // btnAcerca
            // 
            btnAcerca.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAcerca.FlatAppearance.BorderSize = 0;
            btnAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAcerca.ForeColor = System.Drawing.Color.Black;
            btnAcerca.Location = new System.Drawing.Point(282, 3);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new System.Drawing.Size(57, 24);
            btnAcerca.TabIndex = 104;
            btnAcerca.Text = "Acerca";
            btnAcerca.UseVisualStyleBackColor = true;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCerrar.Location = new System.Drawing.Point(345, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(57, 24);
            btnCerrar.TabIndex = 102;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(3, 3);
            lblTitulo.Margin = new System.Windows.Forms.Padding(3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(170, 24);
            lblTitulo.TabIndex = 103;
            lblTitulo.Text = "CLUB DEPORTIVO";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblTitulo.MouseDown += mouse_down;
            lblTitulo.MouseMove += mouse_move;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(405, 244);
            Controls.Add(tlpMenu);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmBase";
            Text = "FormBase";
            tlpMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAcerca;
    }
}