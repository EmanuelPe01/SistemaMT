using System;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public abstract class Conexion
    {
        private readonly string connectionString;

        private string servidor = "localhost";
        private string bd = "sistema";
        private string usuario = "root";
        private string pass = "pass";

        public Conexion()
        {
            connectionString = "Database = " + bd + 
                                "; Data source = " + servidor + 
                                "; User Id = " + usuario + 
                                "; Password = " + pass + ";";
        }

        protected MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conexionDB = new MySqlConnection(connectionString);
                return conexionDB;
            } catch (MySqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
        }
    }
}
