using DataAccess;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoMath_2._0.Forms.CrudProfesor
{
    public partial class NewRegProfesor : Form
    {
        TextInfo myTI = new CultureInfo("es-MX", false).TextInfo;
        public NewRegProfesor(string nameWindow)
        {
            InitializeComponent();
            this.Text = nameWindow;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cancelar registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            ProfesoresDao _newreg = new ProfesoresDao();
            _newreg.Nombre = myTI.ToTitleCase(txtNombre.Text);
            _newreg.A_paterno = myTI.ToTitleCase(txtPaterno.Text);
            _newreg.A_materno = myTI.ToTitleCase(txtMaterno.Text);
            _newreg.Tel_casa = txtCasa.Text;
            _newreg.Tel_cel = txtCelular.Text;
            _newreg.E_mail = txtE_mail.Text;
            _newreg.Red = txtRed.Text;
            _newreg.Perfil = txtPerfil.Text;

            ProfesorModel reg = new ProfesorModel();

            if (_newreg.Nombre.Length > 0 && _newreg.A_paterno.Length > 0 && _newreg.A_materno.Length > 0 && _newreg.Tel_casa.Length > 0 && _newreg.Tel_cel.Length > 0 && _newreg.E_mail.Length > 0 && _newreg.Red.Length > 0 && _newreg.Perfil.Length > 0)
            {
                if (ValidateEmail(_newreg.E_mail))
                {
                    if (ValidateTelNumber(_newreg.Tel_casa) && ValidateTelNumber(_newreg.Tel_cel))
                    {
                        if (txtId.Text != "")
                        {
                            _newreg.Id = int.Parse(txtId.Text);
                            if (!reg.RegExist(_newreg.Tel_casa, _newreg.Tel_cel, _newreg.E_mail, 1))
                                bandera = reg.actualizar(_newreg);
                            else
                                msgError("Ya existen usuarios con el mismo teléfono y/o email");
                        }
                        else
                        {
                            if (!reg.RegExist(_newreg.Tel_casa, _newreg.Tel_cel, _newreg.E_mail, 0))
                                bandera = reg.insertar(_newreg);
                            else
                                msgError("Ya existen usuarios con el mismo teléfono y/o email");
                        }
                        if (bandera)
                        {
                            MessageBox.Show("Registro guardado");
                            this.Close();
                        }
                    }
                    else msgError("Ingrese un número de teléfono válido");
                }
                else msgError("Ingrese un email válido");
            }
            else msgError("Rellene todos los campos");
        }
        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }
        private bool ValidateEmail(String email)
        {
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateTelNumber(string strNumber)
        {
            Regex regex = new Regex(@"\A[0-9]{7,10}\Z");
            Match match = regex.Match(strNumber);

            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
