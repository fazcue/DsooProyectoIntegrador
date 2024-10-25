using ProyectoIntegrador.Datos;
using ProyectoIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmListarMorosos : FrmBase
    {
        public FrmListarMorosos()
        {
            InitializeComponent();
        }

        private void Loading(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        private void CargaGrilla()
        {
            // consultar listado de morosos
            List<E_Socio> morosos = Socio.ListarMorosos();

            if (morosos.Count > 0)
            {
                for (int i = 0; i < morosos.Count; i++)
                {
                    // nuevo renglón
                    dtgvMorosos.Rows.Add();

                    // carga de datos
                    dtgvMorosos.Rows[i].Cells[0].Value = morosos[i].Nombre;
                    dtgvMorosos.Rows[i].Cells[1].Value = morosos[i].Apellido;
                    dtgvMorosos.Rows[i].Cells[2].Value = morosos[i].Dni;
                    dtgvMorosos.Rows[i].Cells[3].Value = morosos[i].Fecha_vencimiento_cuota.ToString("dd-MM-yyyy");
                }

                // visibilidad de elementos
                lblMensajeAlDia.Visible = false;
                dtgvMorosos.Visible = true;
            }
            else
            {
                // visibilidad de elementos
                dtgvMorosos.Visible = false;
                lblMensajeAlDia.Visible = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form menuPrincipal = new FrmMenuPrincipal();
            menuPrincipal.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtgvMorosos.Rows.Clear();
            CargaGrilla();
        }
    }
}
