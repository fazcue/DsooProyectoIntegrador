using ProyectoIntegrador.Datos;
using ProyectoIntegrador.Entidades;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmPagarCuota : FrmBase
    {
        private decimal CUOTA_MENSUAL = 8000;
        private decimal CUOTA_DIARIA = 1500;

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

            DateTime vencimiento = DateTime.ParseExact(lblVencimientoCliente.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            decimal monto;

            // Actualizar fecha de vencimiento y monto según tipo
            if (cboTipo.SelectedIndex == 0)
            {
                vencimiento = vencimiento.AddMonths(1);
                monto = this.CUOTA_MENSUAL;
            }
            else
            {
                if (vencimiento < DateTime.Now)
                {
                    vencimiento = DateTime.Now;
                }

                vencimiento = vencimiento.AddDays(1);
                monto = this.CUOTA_DIARIA;
            }

            // Realizar el pago
            bool res = Cliente.PagarCuota(txtDni.Text, vencimiento.ToString("yyyy-MM-dd"), monto, cboFormaPago.Text, cboCuotas.Text);

            if (res)
            {
                lblVencimientoCliente.Text = vencimiento.ToString("dd/MM/yyyy");
                MessageBox.Show("Pago recibido correctamente.\nNuevo vencimiento: " + lblVencimientoCliente.Text);
            }
            else
            {
                MessageBox.Show("Error: No se ha registrado el pago");
            }

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

                lblMontoCliente.Text = cboTipo.SelectedIndex == 0 ? "$" + this.CUOTA_MENSUAL.ToString() : "$" + this.CUOTA_DIARIA.ToString();

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
