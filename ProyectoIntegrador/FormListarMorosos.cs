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
            List<E_Cliente> morosos = Cliente.ListarMorosos();

            if (morosos.Count > 0)
            {
                MessageBox.Show("Hay morosos");

                for (int i = 0; i < morosos.Count; i++)
                {
                    dtgvMorosos.Rows.Add();

                    dtgvMorosos.Rows[i].Cells[0].Value = morosos[i].Nombre;
                    dtgvMorosos.Rows[i].Cells[1].Value = morosos[i].Apellido;
                    dtgvMorosos.Rows[i].Cells[2].Value = morosos[i].Dni;
                    dtgvMorosos.Rows[i].Cells[3].Value = i;
                }
            }
            else
            {
                MessageBox.Show("NO Hay morosos");
            }
        }
    }
}
