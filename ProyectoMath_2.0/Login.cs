using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace ProyectoMath_2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.FromArgb(224, 224, 224);
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Usuario")
            {
                if(txtPass.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        Inicio_Admin inicio = new Inicio_Admin(txtUser.Text);
                        inicio.Show();
                        inicio.FormClosed += logOut;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario y/o contraseña incorrectos.\nIntenta de nuevo");
                        txtPass.Text = "Contraseña";
                        txtPass.UseSystemPasswordChar = false;
                        txtUser.Focus();
                    }
                } else msgError("Por favor, ingrese la contraseña");
            }
            else msgError("Por favor, ingrese nombre de ususario");
        }

        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private void logOut(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "Contraseña";
            txtPass.UseSystemPasswordChar = false;
            txtUser.Text = "Usuario";
            lblError.Visible = false;
            txtPass.ForeColor = Color.FromArgb(224, 224, 224);
            txtUser.ForeColor = Color.FromArgb(224, 224, 224);
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
