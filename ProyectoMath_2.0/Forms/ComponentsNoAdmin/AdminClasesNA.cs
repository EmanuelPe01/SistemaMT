using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMath_2._0.Forms.ComponentsNoAdmin
{
    public partial class AdminClasesNA : Form
    {
        public AdminClasesNA()
        {
            InitializeComponent();
            cargar_tabla_clases(null);
        }
        private void cargar_tabla_clases(string dato)
        {
            ClaseModel _ctrlClases = new ClaseModel();
            dataClases.DataSource = _ctrlClases.consulta(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar_tabla_clases(txtClase.Text);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
