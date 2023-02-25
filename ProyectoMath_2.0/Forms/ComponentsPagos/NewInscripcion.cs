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
    public partial class NewInscripcion : Form
    {
        public NewInscripcion(string user)
        {
            InitializeComponent();
            txtUser.Text = user;
            cargarClases();
        }
        private void cargarPrecios(string dato)
        {
            
            ClaseModel clasesDao = new ClaseModel();
            txtCosto.Text = clasesDao.consultaPrecio(dato).ToString();
        }

        private void cargarClases()
        {
            cbxClases.DataSource = null;
            cbxClases.Items.Clear();
            ClaseModel clasesModel = new ClaseModel();
            DataTable dt = clasesModel.cargarClases();
            cbxClases.ValueMember = "id_clase";
            cbxClases.DisplayMember = "nombre_clase";
            cbxClases.DataSource = dt;
        }

        private void cbxClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPrecios(cbxClases.SelectedValue.ToString());
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cancelar inscripción?", "Inscripciones", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            double costo = 0;

            if (txtCosto.Text != "")
            {
                if (double.TryParse(txtCosto.Text, out costo))
                {
                    InscripcionesDao _newreg = new InscripcionesDao();
                    _newreg.Id_clase = int.Parse(cbxClases.SelectedValue.ToString());
                    _newreg.Id_alumno = int.Parse(txt_id.Text);
                    _newreg.Costo = costo;
                    _newreg.Comentario = txtCom.Text;

                    InscripcionModel reg = new InscripcionModel();
                    if (!reg.verifyExist(_newreg.Id_clase, _newreg.Id_alumno, 0))
                    {
                        bandera = reg.insertar(_newreg);

                        if (bandera)
                        {
                            if (MessageBox.Show("¿Desea realizar otra inscripción", "Registro realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                this.Close();
                            else
                            {
                                lblError.Visible = false;
                                limpiar();
                            }
                        }
                    }
                    else msgError("El alumno ya cuenta con registro en esta clase");
                }
                else msgError("Ingrese una cantidad válida");
            }
            else msgError("Ingrese un valor en precio");

            
        }
        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private void limpiar()
        {
            txtCom.Text = "";
            txtCosto.Text = "";
        }
    }
}
