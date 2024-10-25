using ProyectoIntegrador.Datos;
using ProyectoIntegrador.Entidades;
using System;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmAltaCliente : FrmBase
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboTipo.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtDni.Text != "")
            {
                E_Cliente nuevo = new E_Cliente(txtNombre.Text, txtApellido.Text, txtDni.Text);
                bool res = Cliente.AltaCliente(cboTipo.Text, nuevo);

                string mensaje = res ? "Registro completado con éxito!" : "El número de DNI ingresado ya existe en la base de datos.";
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Es necesario que completes todos los campos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form menuPrincipal = new FrmMenuPrincipal();
            menuPrincipal.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            cboTipo.SelectedIndex = -1;
        }
    }
}
