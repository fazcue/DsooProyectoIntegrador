using ProyectoIntegrador.Datos;
using ProyectoIntegrador.Entidades;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmPagarCuota : FrmBase
    {
        private decimal cuotaMensual = 8000;
        private decimal cuotaDiaria = 1500;

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

            // Actualizar fecha vencimiento
            DateTime vencimiento = DateTime.ParseExact(lblVencimientoCliente.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Socio
            if (cboTipo.SelectedIndex == 0)
            {
                vencimiento = vencimiento.AddMonths(1);
            }
            else
            {
                if (vencimiento < DateTime.Now)
                {
                    vencimiento = DateTime.Now;
                }

                vencimiento = vencimiento.AddDays(1);
            }

            lblVencimientoCliente.Text = vencimiento.ToString("dd/MM/yyyy");
            Cliente.PagarCuota(txtDni.Text, vencimiento.ToString("yyyy-MM-dd"), cuotaMensual, cboFormaPago.Text, cboCuotas.Text);

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

            E_Cliente cliente = cboTipo.SelectedIndex == 0 ? Socio.Buscar(txtDni.Text) : NoSocio.Buscar(txtDni.Text);

            if (cliente != null)
            {
                lblNombreCliente.Text = cliente.Nombre;
                lblApellidoCliente.Text = cliente.Apellido;

                DateTime vencimiento = cliente.Fecha_vencimiento_cuota;
                lblVencimientoCliente.Text = vencimiento.ToString("dd/MM/yyyy");

                lblMontoCliente.Text = "$" + cuotaMensual.ToString();

                // habilitar elementos para realizar el pago
                btnPagar.Enabled = true;
                cboFormaPago.Enabled = true;
            }
            else
            {
                MessageBox.Show(cboTipo.SelectedIndex == 0 ? "Socio no encontrado" : "No socio no encontrado");
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
