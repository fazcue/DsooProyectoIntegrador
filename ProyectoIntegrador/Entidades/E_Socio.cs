using System;

namespace ProyectoIntegrador.Entidades
{
    internal class E_Socio : E_Cliente
    {
        private int nro_carnet;
        private DateTime fecha_vencimiento_cuota;

        public E_Socio(string nombre, string apellido, string dni, int nro_carnet, DateTime fecha_vencimiento_cuota, string estado = "inactivo") : base(nombre, apellido, dni, estado)
        {
            this.nro_carnet = nro_carnet;
            this.fecha_vencimiento_cuota = fecha_vencimiento_cuota;
        }

        public int Nro_carnet { get { return nro_carnet; } }
        public DateTime Fecha_vencimiento_cuota { get { return fecha_vencimiento_cuota; } }
    }
}
