using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class UserDao : Conexion
    {
        private int id;
        private string user;
        private string pass;

        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public bool Login(string User, string Pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * FROM usuarios where user='" + User + "' and pass='" + Pass + "'";

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
