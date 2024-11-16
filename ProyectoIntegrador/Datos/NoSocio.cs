using MySql.Data.MySqlClient;
using ProyectoIntegrador.Entidades;
using System;
using System.Data;

namespace ProyectoIntegrador.Datos
{
    internal class NoSocio
    {
        public static E_NoSocio Buscar(string dni)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            E_NoSocio encontrado = null;

            try
            {
                sqlCon = Conexion.Crear();
                // query para buscar al socio por su dni
                string query = "SELECT c.nombre, c.apellido, c.dni, c.fecha_vencimiento_cuota " +
                               "FROM cliente c JOIN nosocio ns ON ns.id_cliente = c.id " +
                               "WHERE c.dni = @dni;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@dni", dni);

                sqlCon.Open();
                MySqlDataReader respuesta = comando.ExecuteReader();

                if (respuesta.HasRows && respuesta.Read())
                {
                    // extraemos los datos del socio
                    string nombre = respuesta["nombre"].ToString();
                    string apellido = respuesta["apellido"].ToString();
                    DateTime fecha_vencimiento_cuota = (DateTime)respuesta["fecha_vencimiento_cuota"];

                    // nueva instancia de E_Socio con los datos obtenidos
                    encontrado = new E_NoSocio(nombre, apellido, dni, fecha_vencimiento_cuota);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el no socio. " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return encontrado;
        }
    }
}
