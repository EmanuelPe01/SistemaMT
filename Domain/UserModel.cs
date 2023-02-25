using System;
using System.Collections.Generic;
using DataAccess;
using MySql.Data.MySqlClient;

namespace Domain
{
    public class UserModel : Conexion
    {
        UserDao userDao = new UserDao();

        public bool LoginUser(string User, string Pass)
        {
            return userDao.Login(User, Pass);
        }

        public List<object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null || dato == "")
            {
                sql = "SELECT * FROM usuarios";
            } else
            {
                sql = "SELECT * FROM usuarios WHERE user = '"+ dato +"';";
            }

            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    UserDao _reg = new UserDao();
                    _reg.Id = int.Parse(reader.GetString(0));
                    _reg.User = reader.GetString(1);
                    byte[] encryted = System.Text.Encoding.Unicode.GetBytes(reader.GetString(2));
                    _reg.Pass = Convert.ToBase64String(encryted);
                    lista.Add(_reg);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            } 
            return lista;
        }
        public bool insertar(UserDao datos)
        {
            
            bool bandera = false;
            string sql_ = "INSERT INTO usuarios (user, pass) VALUES ('" + datos.User + "','" + datos.Pass + "');";
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

        public bool actualizar(UserDao datos)
        {

            bool bandera = false;
            string sql_ = "UPDATE usuarios SET user = '" + datos.User + "', pass = '" + datos.Pass + "' WHERE id = '" + datos.Id + "'";
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

        public bool valueExist(string dato, int contexto)
        {
            MySqlDataReader reader;
            bool bandera = false;
            int contador = 0;
            string sql = "SELECT id FROM usuarios WHERE user = '" + dato +"';";
            
            try
            {
                MySqlConnection conexionBD = GetConnection();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read()) contador++;

                if (contador > contexto) bandera = true;
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }
    }
}
