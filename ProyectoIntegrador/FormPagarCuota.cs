using ProyectoIntegrador.Datos;
using ProyectoIntegrador.Entidades;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmPagarCuota : FrmBase
    {
        private float cuotaMensual = 8000;
        private float cuotaDiaria = 1500;

        public FrmPagarCuota()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form menuPrincipal = new FrmMenuPrincipal();
            menuPrincipal.Show();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Si no selecciono forma de pago, mostrar mensaje
            if (cboFormaPago.SelectedIndex == -1 || cboCuotas.SelectedIndex == -1)
            {
                MessageBox.Show("Indica forma de pago y cuotas");
                return;
            }

            // Socio
            if (cboTipo.SelectedIndex == 0)
            {
                // Actualizar fecha vencimiento
                DateTime vencimiento = DateTime.ParseExact(lblVencimientoCliente.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime nuevoVencimiento = vencimiento.AddMonths(1);
                lblVencimientoCliente.Text = nuevoVencimiento.ToString("dd/MM/yyyy");

                Socio.PagarCuota(txtDni.Text, nuevoVencimiento.ToString("yyyy-MM-dd"));
            }

            // no socio
            if (cboTipo.SelectedIndex == 1)
            {
                // Actualizar fecha vencimiento
                DateTime vencimiento = DateTime.ParseExact(lblVencimientoCliente.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime nuevoVencimiento = vencimiento.AddDays(1);
                lblVencimientoCliente.Text = nuevoVencimiento.ToString("dd/MM/yyyy");

                NoSocio.PagarCuota(txtDni.Text, nuevoVencimiento.ToString("yyyy-MM-dd"));
            }

            // Mostrar mensaje y reestablecer forma de pago
            MessageBox.Show("Pago recibido correctamente.\nNuevo vencimiento: " + lblVencimientoCliente.Text);
            cboFormaPago.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cboTipo.SelectedIndex == -1 || txtDni.Text == "")
            {
                MessageBox.Show("Indica tipo de cliente y su DNI");
                return;
            }

            // socio
            if (cboTipo.SelectedIndex == 0)
            {
                E_Socio socio = Socio.Buscar(txtDni.Text);

                if (socio != null)
                {
                    lblNombreCliente.Text = socio.Nombre;
                    lblApellidoCliente.Text = socio.Apellido;

                    DateTime vencimiento = socio.Fecha_vencimiento_cuota;
                    lblVencimientoCliente.Text = vencimiento.ToString("dd/MM/yyyy");

                    lblMontoCliente.Text = "$" + cuotaMensual.ToString();

                    // habilitar elementos para realizar el pago
                    btnPagar.Enabled = true;
                    cboFormaPago.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Socio no encontrado");
                }
            }

            // no socio
            if (cboTipo.SelectedIndex == 1)
            {
                E_NoSocio noSocio = NoSocio.Buscar(txtDni.Text);

                if (noSocio != null)
                {
                    lblNombreCliente.Text = noSocio.Nombre;
                    lblApellidoCliente.Text = noSocio.Apellido;

                    DateTime vencimiento = noSocio.Fecha_vencimiento_cuota;
                    lblVencimientoCliente.Text = vencimiento.ToString("dd/MM/yyyy");

                    lblMontoCliente.Text = "$" + cuotaDiaria.ToString();

                    // habilitar elementos para realizar el pago
                    btnPagar.Enabled = true;
                    cboFormaPago.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No Socio no encontrado");
                }
            }
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si es en efectivo, asignar 1 cuota
            if (cboFormaPago.SelectedIndex == 0)
            {
                cboCuotas.SelectedIndex = 0;
                cboCuotas.Enabled = false;
            }

            // Si es con tarjeta, habilitar cuotas
            if (cboFormaPago.SelectedIndex == 1)
            {
                cboCuotas.Enabled = true;
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipo.SelectedIndex)
            {
                case 0:
                    lblSubtitulo.Text = "Pagar Cuota Socio";
                    break;
                case 1:
                    lblSubtitulo.Text = "Pagar Cuota NO Socio";
                    break;
                default:
                    lblSubtitulo.Text = "Pagar Cuota";
                    break;
            }
        }
    }
}
