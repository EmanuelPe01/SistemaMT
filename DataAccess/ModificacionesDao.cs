using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ModificacionesDao
    {
        private int id;
        private string nombre;
        private string user;
        private DateTime fecha;
        private string tipo;
        private string origen;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string User { get => user; set => user = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Origen { get => origen; set => origen = value; }
    }
}
