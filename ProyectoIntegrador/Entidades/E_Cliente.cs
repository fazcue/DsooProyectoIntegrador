using System;

namespace ProyectoIntegrador.Entidades
{
    internal class E_Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;
        private DateTime fecha_vencimiento_cuota;

        public E_Cliente(string nombre, string apellido, string dni, DateTime fecha_vencimiento_cuota)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fecha_vencimiento_cuota = fecha_vencimiento_cuota;
        }

        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public string Dni { get { return dni; } }
        public DateTime Fecha_vencimiento_cuota { get { return fecha_vencimiento_cuota; } }
    }
}
