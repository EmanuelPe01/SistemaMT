using DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class InscripcionModel : Conexion
    {
        public List<object> consulta(int dato)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();
            string sql;
            sql = "SELECT inscripciones.id_inscripcion, clases.nombre_clase, inscripciones.costo, inscripciones.fecha, inscripciones.comentario, inscripciones.id_alumno, clases.id_clase From inscripciones inner join clases on inscripciones.id_clase = clases.id_clase WHERE inscripciones.id_alumno = '" + dato + "' ORDER BY inscripciones.id_inscripcion ASC;";
            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    InscripcionesDao _reg = new InscripcionesDao();
                    _reg.Id_inscripcion = int.Parse(reader.GetString(0));
                    _reg.Nombre_clase = reader.GetString(1);
                    _reg.Costo = double.Parse(reader.GetString(2));
                    _reg.Fecha = DateTime.Parse(reader.GetString(3));
                    _reg.Comentario = reader.GetString(4);
                    _reg.Id_alumno = int.Parse(reader.GetString(5));
                    _reg.Id_clase = int.Parse(reader.GetString(6));
                    lista.Add(_reg);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(InscripcionesDao datos)
        {
            bool bandera = false;
            DateTime hoy = DateTime.Now;
            string fecha = hoy.ToString("yyyy/MM/dd");

            string sql = "INSERT INTO inscripciones (id_alumno, id_clase, costo, fecha, comentario) VALUES ('" + datos.Id_alumno + "','" + datos.Id_clase + "','" + datos.Costo + "','" + fecha + "','" + datos.Comentario + "')";

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

        public bool actualizar(InscripcionesDao datos, string user, string alumno)
        {
            bool bandera = false;

            DateTime hoy = DateTime.Now;
            string fecha = hoy.ToString("yyyy/MM/dd");
            string sql_2 = "INSERT INTO modificaciones (`nombre`, `user`, `fecha`, `tipo`, `origen`) VALUES ('" + alumno + "', '" + user + "', '" + fecha + "', 'Modificación', 'Inscripción')";
            string sql = "UPDATE inscripciones SET costo='" + datos.Costo + "', comentario='" + datos.Comentario + "' WHERE id_inscripcion='" + datos.Id_inscripcion + "';";

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlCommand comando_2 = new MySqlCommand(sql_2, conexionBD);
                comando_2.ExecuteNonQuery();
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }

        public bool verifyExist(int idClase, int idAlumno, int context)
        {
            bool bandera = false;
            int contador = 0;
            string sql = "SELECT id_inscripcion FROM inscripciones WHERE id_alumno = '" + idAlumno + "' and id_clase = '" + idClase + "';";

            try
            {
                MySqlConnection conexionDB = GetConnection();
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()) contador++;

                if (contador > context) bandera = true;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return bandera;
        }

        public bool eliminar_ins(int id, string alumno, string user)
        {
            bool bandera = false;
            DateTime hoy = DateTime.Now;
            string fecha = hoy.ToString("yyyy/MM/dd");
            string sql_2 = "INSERT INTO modificaciones (`nombre`, `user`, `fecha`, `tipo`, `origen`) VALUES ('" + alumno + "', '" + user + "', '" + fecha + "', 'Eliminación', 'Inscripción')";
            string sql = "DELETE FROM inscripciones WHERE id_inscripcion='" + id + "'";


            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlCommand comando_2 = new MySqlCommand(sql_2, conexionBD);
                comando.ExecuteNonQuery();
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
