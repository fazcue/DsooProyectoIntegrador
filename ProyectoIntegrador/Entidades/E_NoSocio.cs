using System;

namespace ProyectoIntegrador.Entidades
{
    internal class E_NoSocio : E_Cliente
    {
        public E_NoSocio(string nombre, string apellido, string dni, DateTime fecha_vencimiento_cuota)
            : base(nombre, apellido, dni, fecha_vencimiento_cuota)
        {
        }
    }
}
