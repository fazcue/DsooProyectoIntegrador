using System;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador.Datos
{
    public class Conexion
    {
        private static string baseDatos = "clubdeportivo10";
        private static string servidor = "localhost";
        private static string puerto = "3306";
        private static string usuario = "root";
        private static string clave = "root";

        public static MySqlConnection Crear()
        {
            MySqlConnection conexion = new MySqlConnection();

            try
            {
                string conString = $"datasource={servidor};port={puerto};username={usuario};password={usuario};password={clave};Database={baseDatos}";

                conexion.ConnectionString = conString;
            }
            catch (Exception ex)
            {
                throw;
            }

            return conexion;
        }
    }
}
