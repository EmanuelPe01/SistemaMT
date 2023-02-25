using DataAccess;
using Domain;
using ProyectoMath_2._0.Forms.CrudProfesor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMath_2._0.Forms
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
            cargar_tabla(null);
        }
        private void Profesores_Load(object sender, EventArgs e)
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
            List<ProfesoresDao> lista = new List<ProfesoresDao>();
            ProfesorModel _mostrarDatos = new ProfesorModel();
            data_profesores.DataSource = _mostrarDatos.consulta(dato);
        }

        private void btnNewReg_Click(object sender, EventArgs e)
        {
            NewRegProfesor newRegProfesor = new NewRegProfesor("Registrar nuevo profesor");
            newRegProfesor.ShowDialog();
            cargar_tabla(null);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdProf.Text != "")
            {
                NewRegProfesor modReg = new NewRegProfesor("Modificar datos del profesor");
                modReg.txtId.Text = data_profesores.CurrentRow.Cells[0].Value.ToString();
                modReg.txtId.Text = data_profesores.CurrentRow.Cells[0].Value.ToString();
                modReg.txtNombre.Text = data_profesores.CurrentRow.Cells[1].Value.ToString();
                modReg.txtPaterno.Text = data_profesores.CurrentRow.Cells[2].Value.ToString();
                modReg.txtMaterno.Text = data_profesores.CurrentRow.Cells[3].Value.ToString();
                modReg.txtCasa.Text = data_profesores.CurrentRow.Cells[4].Value.ToString();
                modReg.txtCelular.Text = data_profesores.CurrentRow.Cells[5].Value.ToString();
                modReg.txtE_mail.Text = data_profesores.CurrentRow.Cells[6].Value.ToString();
                modReg.txtRed.Text = data_profesores.CurrentRow.Cells[7].Value.ToString();
                modReg.txtPerfil.Text = data_profesores.CurrentRow.Cells[8].Value.ToString();

                modReg.ShowDialog();
                cargar_tabla(null);
            }
            else MessageBox.Show("Por favor, seleccione un registro");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            if (txtIdProf.Text != "")
            {
                if (MessageBox.Show("¿Seguro que dese eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(data_profesores.CurrentRow.Cells[0].Value.ToString());
                    ProfesorModel _eliminar = new ProfesorModel();
                    bandera = _eliminar.eliminar(id);
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

        private void data_profesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProf.Text = data_profesores.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
