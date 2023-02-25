using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ProfesoresDao
    {
        private int id;
        private string nombre;
        private string a_paterno;
        private string a_materno;
        private string tel_casa;
        private string tel_cel;
        private string e_mail;
        private string red;
        private string perfil;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string A_paterno { get => a_paterno; set => a_paterno = value; }
        public string A_materno { get => a_materno; set => a_materno = value; }
        public string Tel_casa { get => tel_casa; set => tel_casa = value; }
        public string Tel_cel { get => tel_cel; set => tel_cel = value; }
        public string E_mail { get => e_mail; set => e_mail = value; }
        public string Red { get => red; set => red = value; }
        public string Perfil { get => perfil; set => perfil = value; }
    }
}
