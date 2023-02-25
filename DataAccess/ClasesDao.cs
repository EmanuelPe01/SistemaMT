using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ClasesDao
    {
        private int id_clase;
        private string nombre_clase;
        private double costo;

        public int Id_clase { get => id_clase; set => id_clase = value; }
        public string Nombre_clase { get => nombre_clase; set => nombre_clase = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}
