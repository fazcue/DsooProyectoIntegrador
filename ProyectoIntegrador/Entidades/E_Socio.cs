using System;

namespace ProyectoIntegrador.Entidades
{
    internal class E_Socio : E_Cliente
    {
        private int nro_carnet;

        public E_Socio(string nombre, string apellido, string dni, int nro_carnet, DateTime fecha_vencimiento_cuota)
            : base(nombre, apellido, dni, fecha_vencimiento_cuota)
        {
            this.nro_carnet = nro_carnet;
        }

        public int Nro_carnet { get { return nro_carnet; } }
    }
}
