using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InscripcionesDao
    {
        private int id_inscripcion;
        private string nombre_clase;
        private double costo;
        private DateTime fecha;
        private string comentario;
        private int id_alumno;
        private int id_clase;
        public int Id_inscripcion { get => id_inscripcion; set => id_inscripcion = value; }
        public string Nombre_clase { get => nombre_clase; set => nombre_clase = value; }
        public double Costo { get => costo; set => costo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public int Id_alumno { get => id_alumno; set => id_alumno = value; }
        public int Id_clase { get => id_clase; set => id_clase = value; }
    }
}
