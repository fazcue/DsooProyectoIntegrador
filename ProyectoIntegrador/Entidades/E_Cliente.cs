using System;

namespace ProyectoIntegrador.Entidades
{
    internal class E_Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string estado;

        public E_Cliente(string nombre, string apellido, string dni, string estado = "inactivo")
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.estado = estado;
        }

        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public string Dni { get { return dni; } }
        public string Estado { get { return estado; } }
    }
}
