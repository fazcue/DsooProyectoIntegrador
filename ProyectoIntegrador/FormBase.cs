using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmBase : Form
    {
        public Point mouseLocation;

        public FrmBase()
        {
            InitializeComponent();
        }

        // Funcionalidad para mover el formulario
        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        // Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Equipo Grupo 10 | 1A:\nErick Romero\nMartín Cáceres\nFacundo Azcue\n\n\nDatos login:\nusuario: admin\nclave: admin", " Proyecto Integrador DSOO 2024 ");
        }
    }
}
