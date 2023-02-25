using DataAccess;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMath_2._0.Forms
{
    public partial class Usuarios : Form
    {
        TextInfo myTI = new CultureInfo("es-MX", false).TextInfo;
        private string user;
        public Usuarios()
        {
            InitializeComponent();
            cargarUsers(null);
        }

        private void cargarUsers(string dato)
        {
            UserModel user = new UserModel();
            dataUsers.DataSource = user.consulta(dato);
        }

        private void Usuarios_Load(object sender, EventArgs e)
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

        private void dataUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] decryted = Convert.FromBase64String(dataUsers.CurrentRow.Cells[2].Value.ToString());
            

            txtId.Text = dataUsers.CurrentRow.Cells[0].Value.ToString();
            txtUser.Text = dataUsers.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = System.Text.Encoding.Unicode.GetString(decryted);
            user = txtUser.Text;

            if (txtPass.UseSystemPasswordChar == false)
                txtPass.UseSystemPasswordChar = true;
        }

        private void limpiar()
        {
            txtId.Text = "";
            txtPass.Text = "";
            txtText.Text = "";
            txtUser.Text = "";
        }
        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" || txtPass.Text != "")
                if (MessageBox.Show("¿Desea cancelar el registro?", "Cancelar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    limpiar();
                    lblError.Visible = false;
                }
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserModel usuario = new UserModel();
            UserDao dataUser = new UserDao();
            bool bandera = false;
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                dataUser.User = myTI.ToTitleCase(txtUser.Text);
                dataUser.Pass = txtPass.Text;
                if (txtId.Text == "")
                {
                    if (!usuario.valueExist(txtUser.Text, 0))
                    {
                        bandera = usuario.insertar(dataUser);
                    }
                    else msgError("Ya existe un usuario con el mismo nombre");
                }
                else {
                    if (!usuario.valueExist(txtUser.Text, 1))
                    {
                        if ((user == txtUser.Text && user == "Admin") || user != "Admin")
                        {
                            dataUser.Id = int.Parse(txtId.Text);
                            bandera = usuario.actualizar(dataUser);
                        }
                        else msgError("No se puede cambiar de nombre al administrador");
                    }
                    else msgError("Ya existe un usuario con el mismo nombre");
                }

                if (bandera)
                {
                    MessageBox.Show("Registrado correctamente");
                    limpiar();
                    cargarUsers(null);
                }
            }
            else msgError("Rsellene todos los campos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarUsers(txtText.Text);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
                txtPass.UseSystemPasswordChar = false;
            else txtPass.UseSystemPasswordChar = true;
        }
    }
}
