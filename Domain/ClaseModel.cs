using DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Domain
{
    public class ClaseModel : Conexion
    {
        public List<object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();
            string sql;
            
            if (dato == null || dato == "")
            {
                sql = "SELECT id_clase, nombre_clase, costo FROM clases ;";
            } else
            {
                sql = "SELECT id_clase, nombre_clase, costo FROM clases WHERE nombre_clase = '" + dato + "';";
            }

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ClasesDao _reg = new ClasesDao();
                    _reg.Id_clase = int.Parse(reader.GetString(0));
                    _reg.Nombre_clase = reader.GetString(1);
                    _reg.Costo = double.Parse(reader.GetString(2));
                    lista.Add(_reg);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public Double consultaPrecio(string dato)
        {
            MySqlDataReader reader;
            double precio = 0;
            string sql;
            sql = "SELECT costo FROM clases WHERE id_clase = '" + dato + "';";
            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read()) precio = double.Parse(reader.GetString(0));
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return precio;
        }

        public DataTable cargarClases()
        {
            string sql = "SELECT * FROM clases ORDER BY nombre_clase ASC;";
            DataTable dt = new DataTable();

            MySqlConnection conexionBD = GetConnection();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                data.Fill(dt);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cargar " + ex.ToString());
                dt = null;
            }
            finally
            {
                conexionBD.Close();
            }

            return dt;
        }

        public bool insertar(ClasesDao datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO clases (nombre_clase, costo) VALUES ('" + datos.Nombre_clase + "','" + datos.Costo + "');";

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }
        public bool actualizar(ClasesDao datos)
        {
            bool bandera = false;

            string sql = "UPDATE clases SET nombre_clase='" + datos.Nombre_clase + "',costo='" + datos.Costo + "' WHERE id_clase='" + datos.Id_clase + "';";

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }
        public bool eliminar(int id)
        {
            bool bandera = false;

            string sql = "DELETE FROM  clases WHERE id_clase='" + id + "'";

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }
    }
}
