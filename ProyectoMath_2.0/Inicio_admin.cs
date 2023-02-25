using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMath_2._0
{
    public partial class Inicio_Admin : Form
    {
        // Campos 
        private Button currentButton;
        private int temIndex;
        private Form activateForm;
        TextInfo myTI = new CultureInfo("es-MX", false).TextInfo;


        // Contructor
        public Inicio_Admin(string nameUser)
        {

            InitializeComponent();
            nameUser = myTI.ToTitleCase(nameUser);
            lblNameUser.Text = nameUser;
            btnCloseChild.Visible = false;

            if (nameUser != "Admin")
            {
                btnProf.Visible = false;
                btnIngresos.Visible = false;
                btnModificaciones.Visible = false;
                btnUsers.Visible = false;
            }
        }

        // Metodos
        private Color SelectColor()
        {
            var index = new Random().Next(0, ThemeColor.ColorList.Count());
            while(temIndex == index)
            {
                index = new Random().Next(0, ThemeColor.ColorList.Count());
            }
            temIndex = index;
            string color = ThemeColor.ColorList[temIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void activateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    disableButton();
                    Color color = SelectColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.5);
                    ThemeColor.PrimaryColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChild.Visible = true;
                }
            }
        }

        private void disableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(250, 250, 250);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void openChild(Form childFrom, object btnSender, string nameForm)
        {
            if (activateForm != null)  activateForm.Close();
            activateButton(btnSender);
            activateForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            this.panelChild.Controls.Add(childFrom);
            this.panelChild.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            lblTitle.Text = nameForm;
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            openChild(new Forms.Alumnos(lblNameUser.Text), sender,"ADMINISTRAR ALUMNOS");
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            openChild(new Forms.Profesores(), sender, "ADMINISTRAR PROFESORES");
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            openChild(new Forms.Pagos(lblNameUser.Text), sender, "ADMINISTRAR INGRESOS");
        }
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            openChild(new Forms.Ingresos(), sender, "CONSULTA DE INGRESOS POR FECHA");
        }

        private void btnModificaciones_Click(object sender, EventArgs e)
        {
            openChild(new Forms.Modificaciones(), sender, "CONSULTA DE MODIFICACIONES POR FECHA");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChild(new Forms.Usuarios(), sender, "ADMINISTRAR USUARIOS");
        }


        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activateForm != null) activateForm.Close();
            Reset();
        }

        private void Reset()
        {
            disableButton();
            lblTitle.Text = "INICIO";
            panelTitleBar.BackColor = Color.White;
            panelLogo.BackColor = Color.Black;
            currentButton = null;
            btnCloseChild.Visible = false;
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Terminar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
