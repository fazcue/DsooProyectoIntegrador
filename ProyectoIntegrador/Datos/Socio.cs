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

            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            try
            {
                sqlCon = Conexion.Crear();

                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand("ListarMorosos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // abrimos la conexion
                sqlCon.Open();

                // almacenamos el resulatdo en la variable
                resultado = comando.ExecuteReader();

                // Si hay morosos, guardarlos en lista 'morosos'
                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        string nombre = resultado["nombre"].ToString();
                        string apellido = resultado["apellido"].ToString();
                        string dni = resultado["dni"].ToString();
                        int nro_carnet = (int)resultado["nro_carnet"];
                        DateTime fecha_vencimiento_cuota = (DateTime)resultado["fecha_vencimiento_cuota"];

                        E_Socio nuevo = new E_Socio(nombre, apellido, dni, nro_carnet, fecha_vencimiento_cuota);
                        morosos.Add(nuevo);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar listar morosos" + ex.Message); ;
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
    }
}
