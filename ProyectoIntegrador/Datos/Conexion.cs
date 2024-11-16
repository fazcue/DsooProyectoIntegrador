using System;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador.Datos
{
    public class Conexion
    {
        private static string baseDatos = "clubdeportivo10";
        private static string servidor;
        private static string puerto;
        private static string usuario;
        private static string clave;

        public static MySqlConnection Crear()
        {
            DatosPorTeclado();
            MySqlConnection conexion = new MySqlConnection();

            try
            {
                string conString = $"datasource={servidor};port={puerto};username={usuario};password={usuario};password={clave};Database={baseDatos}";

                conexion.ConnectionString = conString;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la bd: " + ex.Message);
            }

            return conexion;
        }

        public static void DatosPorTeclado()
        {
            // Verificar si los datos ya han sido configurados
            if (string.IsNullOrEmpty(baseDatos) || string.IsNullOrEmpty(servidor) || string.IsNullOrEmpty(puerto) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                servidor = Microsoft.VisualBasic.Interaction.InputBox("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                puerto = Microsoft.VisualBasic.Interaction.InputBox("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                usuario = Microsoft.VisualBasic.Interaction.InputBox("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                clave = Microsoft.VisualBasic.Interaction.InputBox("ingrese clave", "DATOS DE INSTALACIÓN MySQL");
            }
        }
    }
}
