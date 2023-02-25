using DataAccess;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMath_2._0.Forms
{
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
        }
        private void cargar_tabla_ingresos(DateTime antes, DateTime despues)
        {
            PagoModel _ctrlPagos = new PagoModel();
            dataPagos.DataSource = _ctrlPagos.consulta(antes, despues);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DateTime fecha_ = DateTime.Parse(dateAntes_.Text);
            DateTime fecha_1 = DateTime.Parse(dateDespues.Text);
            cargar_tabla_ingresos(fecha_, fecha_1);
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
    }
}
