using System;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmMenuPrincipal : FrmBase
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            this.Close();

            Form altaCliente = new FrmAltaCliente();
            altaCliente.Show();
        }

        private void btnListarMorosos_Click(object sender, EventArgs e)
        {
            this.Close();

            Form listarMorosos = new FrmListarMorosos();
            listarMorosos.Show();
        }

        private void btnEmitirCarnet_Click(object sender, EventArgs e)
        {
            this.Close();
            Form emitirCarnet = new FrmEmitirCarnet();
            emitirCarnet.Show();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            this.Close();
            Form pagarCuota = new FrmPagarCuota();
            pagarCuota.Show();
        }
    }
}
