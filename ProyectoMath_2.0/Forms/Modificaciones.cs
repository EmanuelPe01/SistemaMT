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
    public partial class Modificaciones : Form
    {
        public Modificaciones()
        {
            InitializeComponent();
        }
        private void Modificaciones_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        public void cargarModifiaciones(DateTime fecha_1, DateTime fecha_2)
        {
            ModificacionModel modificacionModel = new ModificacionModel();
            dataModificaciones.DataSource = modificacionModel.consulta(fecha_1, fecha_2);
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cargarModifiaciones(DateTime.Parse(dateAntes_.Text), DateTime.Parse(dateDespues.Text));
        }

    }
}
