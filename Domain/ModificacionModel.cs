using DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ModificacionModel : Conexion
    {
        public List<object> consulta(DateTime dato_, DateTime dato_2)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();
            string sql;
            string fecha_1 = dato_.ToString("yyyy-MM-dd");
            string fecha_2 = dato_2.ToString("yyyy-MM-dd");

            sql = "Select * FROM modificaciones WHERE fecha BETWEEN '" + fecha_1 + "' AND '" + fecha_2 + "';";

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ModificacionesDao _reg = new ModificacionesDao();
                    _reg.Id = int.Parse(reader.GetString(0));
                    _reg.Nombre = reader.GetString(1);
                    _reg.User = reader.GetString(2);
                    _reg.Fecha = DateTime.Parse(reader.GetString(3));
                    _reg.Tipo = reader.GetString(4);
                    _reg.Origen = reader.GetString(5);
                    lista.Add(_reg);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
    }
}
