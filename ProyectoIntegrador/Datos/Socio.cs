using MySql.Data.MySqlClient;
using ProyectoIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProyectoIntegrador.Datos
{
    internal class Socio
    {
        public static List<E_Socio> ListarMorosos()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            List<E_Socio> morosos = new List<E_Socio>();

            MySqlDataReader respuesta;
            DateTime fechaActual = DateTime.Now;

            try
            {
                sqlCon = Conexion.Crear();

                // query
                string query = "SELECT c.nombre, c.apellido, c.dni, s.nro_carnet, c.fecha_vencimiento_cuota FROM cliente c JOIN socio s ON s.id_cliente = c.id WHERE c.fecha_vencimiento_cuota <= @fechaActual;";

                // comando de tipo texto utilizando la query definida
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@fechaActual", fechaActual);

                // abrimos la conexion
                sqlCon.Open();

                // almacenamos el resulatdo en la variable
                respuesta = comando.ExecuteReader();

                if (respuesta.HasRows)
                {
                    while (respuesta.Read())
                    {
                        string nombre = respuesta["nombre"].ToString();
                        string apellido = respuesta["apellido"].ToString();
                        string dni = respuesta["dni"].ToString();
                        int nro_carnet = (int)respuesta["nro_carnet"];
                        DateTime fecha_vencimiento_cuota = (DateTime)respuesta["fecha_vencimiento_cuota"];


                        E_Socio nuevo = new E_Socio(nombre, apellido, dni, nro_carnet, fecha_vencimiento_cuota);

                        morosos.Add(nuevo);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return morosos;
        }

        public static E_Socio Buscar(string dni)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            E_Socio encontrado = null;

            try
            {
                sqlCon = Conexion.Crear();
                // query para buscar al socio por su dni
                string query = "SELECT c.nombre, c.apellido, c.dni, s.nro_carnet, c.fecha_vencimiento_cuota " +
                               "FROM cliente c JOIN socio s ON s.id_cliente = c.id " +
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
                    int nro_carnet = (int)respuesta["nro_carnet"];
                    DateTime fecha_vencimiento_cuota = (DateTime)respuesta["fecha_vencimiento_cuota"];

                    // nueva instancia de E_Socio con los datos obtenidos
                    encontrado = new E_Socio(nombre, apellido, dni, nro_carnet, fecha_vencimiento_cuota);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el socio.", ex);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return encontrado;
        }

        public static bool PagarCuota(string dni, string nuevoVencimiento)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            MySqlDataReader respuesta;

            try
            {
                sqlCon = Conexion.Crear();

                // query
                string query = "UPDATE cliente c JOIN socio s ON s.id_cliente = c.id SET fecha_vencimiento_cuota = @nuevoVencimiento WHERE c.dni = @dni;";

                // comando de tipo texto utilizando la query definida
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@nuevoVencimiento", nuevoVencimiento);

                // abrimos la conexion
                sqlCon.Open();

                // almacenamos el resulatdo en la variable
                respuesta = comando.ExecuteReader();

                if (respuesta.HasRows)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al pagar cuota.", ex);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return false;
        }
    }
}
