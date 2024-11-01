using ProyectoIntegrador.Datos;
using ProyectoIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmEmitirCarnet : FrmBase
    {
        public FrmEmitirCarnet()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

            try

            {
                E_Socio socio = Socio.BuscarSocio(dni);

                if (socio != null)
                {
                    // Si el dni ingresado existe y pertenece a un socio activo, se abre FrmSocio y muestra los datos
                    FrmSocio carnetSocio = new FrmSocio();

                    carnetSocio.CargarDatosSocio(
                        socio.Nombre,
                        socio.Apellido,
                        socio.Dni,
                        socio.Nro_carnet.ToString(),
                        socio.Fecha_vencimiento_cuota.ToString("dd/MM/yyyy")
            );

                    this.Close();
                    carnetSocio.Show();
                }
                else
                {
                    // Si el dni ingresado no existe, no pertenece a un socio o pertenece a un socio que se encuentra inactivo retorna el msj
                    MessageBox.Show("El DNI ingresado no existe o no pertenece a un socio de la institución.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el socio: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form menuPrincipal = new FrmMenuPrincipal();
            menuPrincipal.Show();
        }
    }
}
