using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmSocio : FrmBase
    {
        public FrmSocio()
        {
            InitializeComponent();
        }

        public void CargarDatosSocio(string nombre, string apellido, string dni, string nroCarnet, string fechaVencimiento)
        {
            lblNombreSocio.Text = nombre;
            lblApellidoSocio.Text = apellido;
            lblDniSocio.Text = dni;
            lblNroCarnet.Text = nroCarnet;
            lblVencimientoCuota.Text = fechaVencimiento;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form emitirCarnet = new FrmEmitirCarnet();
            emitirCarnet.Show();
        }

        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {

            // objetos para la impresion
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirCarnet);
            pd.Print();

        }

        private void ImprimirCarnet(object sender, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
