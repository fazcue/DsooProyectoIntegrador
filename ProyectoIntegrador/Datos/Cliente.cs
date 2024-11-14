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

            bool respuesta = false;

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
                comando.Parameters.Add("fecha_vencimiento_cuota", MySqlDbType.Enum).Value = nuevo.Fecha_vencimiento_cuota.ToString("yyyy-MM-dd");

                // respuesta
                MySqlParameter outParam = new MySqlParameter("respuesta", MySqlDbType.Int32);
                outParam.Direction = ParameterDirection.Output;
                comando.Parameters.Add(outParam);

                // abrimos la conexion
                sqlCon.Open();

                // almacenamos el resultado en la variable
                comando.ExecuteNonQuery();

                // cargamos la tabla con el resultado
                respuesta = (int)outParam.Value == 1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de alta el cliente: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return respuesta;
        }

        public static bool PagarCuota(string dni, string nuevo_vencimiento, decimal monto, string forma_pago, string total_cuotas)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            bool respuesta = false;

            try
            {
                sqlCon = Conexion.Crear();

                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand("PagarCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("dni", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("nuevo_vencimiento", MySqlDbType.VarChar).Value = nuevo_vencimiento;
                comando.Parameters.Add("monto", MySqlDbType.VarChar).Value = monto;
                comando.Parameters.Add("forma_pago", MySqlDbType.VarChar).Value = forma_pago;
                comando.Parameters.Add("total_cuotas", MySqlDbType.Enum).Value = total_cuotas;

                // respuesta
                MySqlParameter outParam = new MySqlParameter("respuesta", MySqlDbType.Int32);
                outParam.Direction = ParameterDirection.Output;
                comando.Parameters.Add(outParam);

                // abrimos la conexion
                sqlCon.Open();

                // almacenamos el resultado en la variable
                comando.ExecuteNonQuery();

                // cargamos la tabla con el resultado
                respuesta = (int)outParam.Value == 1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al pagar cuota: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return respuesta;
        }
    }
}
