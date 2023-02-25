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
    public partial class ModInscripcion_ : Form
    {
        public ModInscripcion_()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            double costo = 0;

            if (txtCosto.Text != "")
            {
                if (double.TryParse(txtCosto.Text, out costo))
                {
                    InscripcionesDao _newreg = new InscripcionesDao();
                    _newreg.Id_inscripcion = int.Parse(lblIdInscripcion.Text);
                    _newreg.Costo = double.Parse(txtCosto.Text);
                    _newreg.Comentario = txtComentario.Text;
                    _newreg.Id_alumno = int.Parse(lblIdAlumno.Text);

                    InscripcionModel reg = new InscripcionModel();

                    _newreg.Id_inscripcion = int.Parse(lblIdInscripcion.Text);
                    bandera = reg.actualizar(_newreg, txtUser.Text, txtNombre.Text);

                    if (bandera)
                    {
                        MessageBox.Show("Registro guardado");
                        this.Close();
                    }
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
        //    bool bandera = false;
        //    string user = txtUser.Text;
        //    string alumno = txtNombre.Text;

        //    InscripcionesDao _newreg = new InscripcionesDao();
        //    _newreg.Id_inscripcion = int.Parse(txtId.Text);
        //    _newreg.Costo = double.Parse(txtCosto.Text);
        //    _newreg.Comentario = txtComentario.Text;
        //    _newreg.Id_alumno = int.Parse(txtId_a.Text);

        //    InscripcionModel reg = new InscripcionModel();

        //    if (txtId.Text != "")
        //    {
        //        _newreg.Id_inscripcion = int.Parse(txtId.Text);
        //        bandera = reg.actualizar(_newreg, user, alumno);
        //    }
        //    if (bandera)
        //    {
        //        MessageBox.Show("Registro guardado");
        //    }
        //}
    }
}
