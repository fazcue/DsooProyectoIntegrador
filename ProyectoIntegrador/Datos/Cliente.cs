using MySql.Data.MySqlClient;
using ProyectoIntegrador.Entidades;
using System;
using System.Data;

namespace ProyectoIntegrador.Datos
{
    internal class Cliente
    {
        public static bool AltaCliente(string tipo, E_Cliente nuevo)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            bool respuesta;

            try
            {
                sqlCon = Conexion.Crear();

                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand("AltaCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("tipo", MySqlDbType.VarChar).Value = tipo;
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = nuevo.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = nuevo.Apellido;
                comando.Parameters.Add("dni", MySqlDbType.VarChar).Value = nuevo.Dni;
                comando.Parameters.Add("estado", MySqlDbType.Enum).Value = nuevo.Estado;

                // respuesta
                MySqlParameter outParam = new MySqlParameter("respuesta", MySqlDbType.Int32);
                outParam.Direction = ParameterDirection.Output;
                comando.Parameters.Add(outParam);

                // abrimos la conexion
                sqlCon.Open();

                // almacenamos el resulatdo en la variable
                comando.ExecuteNonQuery();

                // cargamos la tabla con el resultado
                respuesta = (int)outParam.Value == 1 ? true : false;

                return respuesta;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
    }
}
