using DataAccess;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMath_2._0.Forms.ComponentsPagos
{
    public partial class AdminClases : Form
    {
        public AdminClases()
        {
            InitializeComponent();
            cargar_tabla_clases(null);
        }
        private void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
        }

        private void cargar_tabla_clases(string dato)
        {
            ClaseModel _ctrlClases = new ClaseModel();
            dataClases.DataSource = _ctrlClases.consulta(dato);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            double costo = 0;

            if (txtCosto.Text != "" && txtNombre.Text != "")
            {
                if (double.TryParse(txtCosto.Text, out costo))
                {
                    ClasesDao _newreg = new ClasesDao();
                    _newreg.Nombre_clase = txtNombre.Text;
                    _newreg.Costo = double.Parse(txtCosto.Text);

                    ClaseModel reg = new ClaseModel();

                    if (txtID.Text != "")
                    {
                        _newreg.Id_clase = int.Parse(txtID.Text);
                        bandera = reg.actualizar(_newreg);
                    }
                    else
                    {
                        bandera = reg.insertar(_newreg);
                    }
                    if (bandera)
                    {
                        MessageBox.Show("Registro guardado");
                        cargar_tabla_clases(null);
                        limpiar();
                    }
                }
                else msgError("Ingrese un precio válido");
            }
            else msgError("Rellene todos los campos");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("¿Desea cancelar la modifición?", "Cancelar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    limpiar();
            }
            else msgError("Seleccione el registro que desea modificar");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataClases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataClases.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataClases.CurrentRow.Cells[1].Value.ToString();
            txtCosto.Text = dataClases.CurrentRow.Cells[2].Value.ToString();
        }
        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar_tabla_clases(txtClase.Text);
        }
    }
}
