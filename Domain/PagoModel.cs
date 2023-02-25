using DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PagoModel : Conexion
    {
        public List<object> consulta(int dato)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();
            string sql;
            sql = "SELECT clases.nombre_clase, pagos.monto, pagos.concepto,pagos.fecha, pagos.comentario FROM pagos left join clases on clases.id_clase = pagos.id_clase_pago WHERE pagos.id_alumno_pago = '" + dato + "';";
            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    PagosDao _reg = new PagosDao();
                    _reg.Nombre_clase = reader.GetString(0);
                    _reg.Monto = double.Parse(reader.GetString(1));
                    _reg.Concepto = reader.GetString(2);
                    _reg.Fecha = DateTime.Parse(reader.GetString(3));
                    _reg.Comentario = reader.GetString(4);
                    lista.Add(_reg);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public List<object> consulta(int dato, int dato_2)
        {

            MySqlDataReader reader;
            List<object> lista = new List<object>();
            string sql;
            sql = "SELECT id_pago, clases.nombre_clase, pagos.monto, pagos.concepto, pagos.fecha, pagos.comentario FROM pagos INNER JOIN clases ON clases.id_clase = pagos.id_clase_pago WHERE id_alumno_pago = '" + dato + "' and clases.id_clase = '" + dato_2 + "';";
            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    PagosDao _reg = new PagosDao();
                    _reg.Id_pago = int.Parse(reader.GetString(0));
                    _reg.Nombre_clase = reader.GetString(1);
                    _reg.Monto = double.Parse(reader.GetString(2));
                    _reg.Concepto = reader.GetString(3);
                    _reg.Fecha = DateTime.Parse(reader.GetString(4));
                    _reg.Comentario = reader.GetString(5);
                    lista.Add(_reg);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public List<object> consulta(DateTime dato_, DateTime dato_2)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();
            string sql;
            string fecha_1 = dato_.ToString("yyyy-MM-dd");
            string fecha_2 = dato_2.ToString("yyyy-MM-dd");

            sql = "SELECT pagos.id_pago, clases.nombre_clase, pagos.monto, pagos.concepto,pagos.fecha, pagos.comentario, pagos.usuario FROM pagos left join clases on clases.id_clase = pagos.id_clase_pago WHERE pagos.fecha BETWEEN '" + fecha_1 + "' AND '" + fecha_2 + "' ORDER BY pagos.fecha ASC;";
            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    PagosDao _reg = new PagosDao();
                    _reg.Id_pago = int.Parse(reader.GetString(0));
                    _reg.Nombre_clase = reader.GetString(1);
                    _reg.Monto = double.Parse(reader.GetString(2));
                    _reg.Concepto = reader.GetString(3);
                    _reg.Fecha = DateTime.Parse(reader.GetString(4));
                    _reg.Comentario = reader.GetString(5);
                    _reg.User = reader.GetString(6);
                    lista.Add(_reg);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public bool insertar(PagosDao datos, int id_alumno, int id_clase, double abono, string concepto, string user)
        {
            bool bandera = false;
            DateTime hoy = DateTime.Now;
            string fecha = hoy.ToString("yyyy/MM/dd"), sql_;
            sql_ = "INSERT INTO pagos (id_alumno_pago, id_clase_pago, monto, concepto, fecha, comentario, usuario) VALUES ('" + id_alumno + "','" + id_clase + "','" + abono + "','" + concepto + "','" + fecha + "','" + datos.Comentario + "', '" + user + "')";
            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql_, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return bandera;
        }
        public bool actualizar(PagosDao datos, int id_alumno, int id_clase, double abono, string concepto, string user, string alumno)
        {
            bool bandera = false;
            DateTime hoy = DateTime.Now;
            string fecha = hoy.ToString("yyyy/MM/dd");
            string sql_2 = "INSERT INTO modificaciones (`nombre`, `user`, `fecha`, `tipo`, `origen`) VALUES ('" + alumno + "', '" + user + "', '" + fecha + "', 'Modificación', 'Pagos')";
            string sql = "UPDATE pagos SET monto='" + abono + "',concepto='" + concepto + "' ,comentario='" + datos.Comentario + "', usuario='" + user + "' WHERE id_alumno_pago='" + id_alumno + "' and id_clase_pago='" + id_clase + "' and id_pago = '" + datos.Id_pago + "';";

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MySqlCommand comando_2 = new MySqlCommand(sql_2, conexionBD);
                comando_2.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }
        public bool eliminar(int id, string alumno, string user)
        {
            bool bandera = false;
            DateTime hoy = DateTime.Now;
            string fecha = hoy.ToString("yyyy/MM/dd");
            string sql_2 = "INSERT INTO modificaciones (`nombre`, `user`, `fecha`, `tipo`, `origen`) VALUES ('" + alumno + "', '" + user + "', '" + fecha + "', 'Eliminación', 'Pagos')";
            string sql = "DELETE FROM  pagos WHERE id_pago='" + id + "'";


            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MySqlCommand comando_2 = new MySqlCommand(sql_2, conexionBD);
                comando_2.ExecuteNonQuery();
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
