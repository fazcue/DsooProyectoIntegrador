using ProyectoIntegrador.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmLogin : FrmBase
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            // Loguear usuario administrador
            DataTable tabla = Usuario.Login(txtUsuario.Text, txtClave.Text);

            // Si se logueo, mostrar formulario Menú Principal
            if (tabla != null && tabla.Rows.Count > 0)
            {
                this.Hide();

                Form menuPrincipal = new FrmMenuPrincipal();
                menuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o clave no válido");
            }

        }
    }
}
