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
            // Si todos los campos han sido completados
            if (cboTipo.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtDni.Text != "")
            {
                // Si el apto fisico ha sido marcado
                if (checkAptoFisico.Checked)
                {
                    // Crear nuevo cliente
                    E_Cliente nuevo = new E_Cliente(txtNombre.Text, txtApellido.Text, txtDni.Text, DateTime.Now);

                    // Darlo de alta
                    bool res = Cliente.AltaCliente(cboTipo.Text, nuevo);

                    // Mensaje respuesta
                    string mensaje = res ? "Registro completado con éxito!" : "El número de DNI ingresado ya existe en la base de datos.";
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Es necesario presentar un apto físico para inscribirse en el club.");
                }
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
            checkAptoFisico.Checked = false;
        }
    }
}
