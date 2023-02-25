using DataAccess;
using Domain;
using ProyectoMath_2._0.Forms.CrudAlumnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMath_2._0.Forms
{
    public partial class Alumnos : Form
    {
        public Alumnos(string nameUser)
        {
            InitializeComponent();
            lblUser.Text = nameUser;
            cargar_tabla(null);
        }

        private void CrudAlumnos_Load(object sender, EventArgs e)
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
        private void cargar_tabla(string dato)
        {
            List<AlumnosDao> lista = new List<AlumnosDao>();
            AlumnoModel mostrarAlumnos = new AlumnoModel();
            data_alumnos.DataSource = mostrarAlumnos.consulta(dato);
        }

        private void btnNewReg_Click(object sender, EventArgs e)
        {
            NewRegAlumno nuevoRegistro = new NewRegAlumno("Registrar nuevo alumno");
            nuevoRegistro.ShowDialog();
            cargar_tabla(null);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lblIdAlumno.Text != "")
            {
                NewRegAlumno modReg = new NewRegAlumno("Modificar datos del alumno");
                modReg.txtId.Text = data_alumnos.CurrentRow.Cells[0].Value.ToString();
                modReg.txtId.Text = data_alumnos.CurrentRow.Cells[0].Value.ToString();
                modReg.txtNombre.Text = data_alumnos.CurrentRow.Cells[1].Value.ToString();
                modReg.txtPaterno.Text = data_alumnos.CurrentRow.Cells[2].Value.ToString();
                modReg.txtMaterno.Text = data_alumnos.CurrentRow.Cells[3].Value.ToString();
                modReg.txtCasa.Text = data_alumnos.CurrentRow.Cells[4].Value.ToString();
                modReg.txtCelular.Text = data_alumnos.CurrentRow.Cells[5].Value.ToString();
                modReg.txtE_mail.Text = data_alumnos.CurrentRow.Cells[6].Value.ToString();
                modReg.txtRed.Text = data_alumnos.CurrentRow.Cells[7].Value.ToString();
                modReg.txtPerfil.Text = data_alumnos.CurrentRow.Cells[8].Value.ToString();
                modReg.txtComentario.Text = data_alumnos.CurrentRow.Cells[9].Value.ToString();
                modReg.txtUser.Text = lblUser.Text;
                modReg.txtAlumno.Text = modReg.txtNombre.Text + " " + modReg.txtPaterno.Text + " " + modReg.txtMaterno.Text;

                modReg.ShowDialog();
                cargar_tabla(null);
            }
            else MessageBox.Show("Por favor, seleccione un registro");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblIdAlumno.Text != "")
            {
                bool bandera = false;
                string alumno = data_alumnos.CurrentRow.Cells[1].Value.ToString() + " " + data_alumnos.CurrentRow.Cells[2].Value.ToString() + " " + data_alumnos.CurrentRow.Cells[3].Value.ToString();
                string user = lblUser.Text;

                if (MessageBox.Show("¿Seguro que dese eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(data_alumnos.CurrentRow.Cells[0].Value.ToString());
                    AlumnoModel _eliminar = new AlumnoModel();
                    bandera = _eliminar.eliminar(id, alumno, user);
                    if (bandera)
                    {
                        MessageBox.Show("Registro Eliminado");
                        cargar_tabla(null);
                    }
                }
            }
            else MessageBox.Show("Por favor, seleccione un registro");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cargar_tabla(txtDato.Text);
        }

        private void data_alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdAlumno.Text = data_alumnos.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
