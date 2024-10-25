using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoIntegrador.Datos
{
    internal class Usuario
    {
        // método que retorna una tabla con la información
        public static DataTable Login(string usuario, string clave)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.Crear();

                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand("Login", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("usuario", MySqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("clave", MySqlDbType.VarChar).Value = clave;

                // abrimos la conexion
                sqlCon.Open();

                // almacenamos el resulatdo en la variable
                resultado = comando.ExecuteReader();

                // cargamos la tabla con el resultado
                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
    }
}
