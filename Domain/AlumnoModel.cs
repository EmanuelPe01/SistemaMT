using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccess;
using MySql.Data.MySqlClient;

namespace Domain
{
    public class AlumnoModel : Conexion
    {
        public List<object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT * FROM alumnos";
            }
            else
            {
                sql = "SELECT * FROM alumnos WHERE nombre LIKE '%" + dato + "%' OR a_paterno LIKE '%" + dato + "%' OR a_materno LIKE '%" + dato + "%' OR tel_casa LIKE '%" + dato + "%' OR tel_cel LIKE '%" + dato + "%' OR e_mail LIKE '%" + dato + "%' OR red_social LIKE '%" + dato + "%' OR perfil_red LIKE '%" + dato + "%' OR comentario LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = GetConnection(); ;
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    AlumnosDao _reg = new AlumnosDao();
                    _reg.Id = int.Parse(reader.GetString(0));
                    _reg.Nombre = reader.GetString(1);
                    _reg.A_paterno = reader.GetString(2);
                    _reg.A_materno = reader.GetString(3);
                    _reg.Tel_casa = reader.GetString(4);
                    _reg.Tel_cel = reader.GetString(5);
                    _reg.E_mail = reader.GetString(6);
                    _reg.Red = reader.GetString(7);
                    _reg.Perfil = reader.GetString(8);
                    _reg.Comentarios = reader.GetString(9);
                    lista.Add(_reg);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(AlumnosDao datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO alumnos (nombre, a_paterno, a_materno, tel_casa, tel_cel, e_mail, red_social, perfil_red, comentario) VALUES ('" + datos.Nombre + "','" + datos.A_paterno + "','" + datos.A_materno + "','" + datos.Tel_casa + "','" + datos.Tel_cel + "','" + datos.E_mail + "','" + datos.Red + "','" + datos.Perfil + "','" + datos.Comentarios + "')";

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
                conexionBD.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return bandera;
        }

        public bool actualizar(AlumnosDao datos, string alumno, string user)
        {
            bool bandera = false;
            DateTime hoy = DateTime.Now;
            string fecha = hoy.ToString("yyyy/MM/dd");
            string sql_2 = "INSERT INTO modificaciones (`nombre`, `user`, `fecha`, `tipo`, `origen`) VALUES ('" + alumno + "', '" + user + "', '" + fecha + "', 'Modificación', 'Alumnos')";
            string sql = "UPDATE  alumnos SET nombre='" + datos.Nombre + "', a_paterno='" + datos.A_paterno + "', a_materno='" + datos.A_materno + "', tel_casa='" + datos.Tel_casa + "', tel_cel='" + datos.Tel_cel + "', e_mail='" + datos.E_mail + "', red_social='" + datos.Red + "', perfil_red='" + datos.Perfil + "', comentario='" + datos.Comentarios + "' WHERE id_alumno='" + datos.Id + "'";

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlCommand comando_2 = new MySqlCommand(sql_2, conexionBD);
                comando_2.ExecuteNonQuery();
                comando.ExecuteNonQuery();
                conexionBD.Close();
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
            string sql_2 = "INSERT INTO modificaciones (`nombre`, `user`, `fecha`, `tipo`, `origen`) VALUES ('" + alumno + "', '" + user + "', '" + fecha + "', 'Eliminación', 'Alumnos')";
            string sql = "DELETE FROM  alumnos WHERE id_alumno='" + id + "'";

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlCommand comando_2 = new MySqlCommand(sql_2, conexionBD);
                comando_2.ExecuteNonQuery();
                comando.ExecuteNonQuery();
                conexionBD.Close();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }

        public bool RegExist(string tel_casa, string tel_cel, string email, int context) 
        {
            // Context -> Si es 0 entonces es nuevo registro y significa que no debe haber ni un registro igual 
            // si es 1 entonces significa que se modifica el registro y hasta ese momento existe al menos un registro con esos datos

            bool bandera = false;
            int contador = 0;
            string sql = "SELECT * FROM alumnos where tel_casa = '" + tel_casa + "' or tel_cel = '" + tel_cel +"' or e_mail = '" + email +"';";

            try
            {
                MySqlConnection conexionDB = GetConnection();
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()) contador++;

                if (contador > context) bandera = true;
              
            } catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return bandera;
        }

    }
}
