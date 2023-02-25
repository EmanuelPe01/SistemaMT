using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class PagosDao
    {
        private int id_pago;
        private string nombre_clase;
        private double monto;
        private string concepto;
        private DateTime fecha;
        private string comentario;
        private double adeudo;
        private string user;

        public string Nombre_clase { get => nombre_clase; set => nombre_clase = value; }
        public double Monto { get => monto; set => monto = value; }
        public string Concepto { get => concepto; set => concepto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public double Adeudo { get => adeudo; set => adeudo = value; }
        public int Id_pago { get => id_pago; set => id_pago = value; }
        public string User { get => user; set => user = value; }
    }
}
