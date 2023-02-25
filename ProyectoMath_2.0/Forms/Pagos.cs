using DataAccess;
using Domain;
using ProyectoMath_2._0.Forms.ComponentsNoAdmin;
using ProyectoMath_2._0.Forms.ComponentsPagos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMath_2._0.Forms
{
    public partial class Pagos : Form
    {
        private string imagen = @"C:\head.jpg", imagen_2 = @"C:\codigo.png";
        public Pagos(string nameUser)
        {
            InitializeComponent();
            lblUser.Text = nameUser;
            cargar_tabla_alumno(null);
        }

        private void Pagos_Load(object sender, EventArgs e)
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
        private void cargar_tabla_alumno(string dato)
        {
            List<AlumnosDao> lista = new List<AlumnosDao>();
            AlumnoModel _ctrlAlumnos = new AlumnoModel();
            data_alumnos.DataSource = _ctrlAlumnos.consulta(dato);
        }

        private void cargar_tabla_pagos(int dato)
        {
            List<PagosDao> lista_pagos = new List<PagosDao>();
            PagoModel _ctrlPagos = new PagoModel();
            data_pagos.DataSource = _ctrlPagos.consulta(dato);
        }

        private void data_alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = int.Parse(data_alumnos.CurrentRow.Cells[0].Value.ToString());
            txt_monto_pago.Text = "";
            cargar_tabla_pagos(n);
        }

        private void data_pagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_monto_pago.Text = data_pagos.CurrentRow.Cells[1].Value.ToString();
        }
        
        private void btn_registro_pago_Click(object sender, EventArgs e)
        {
            if (txtIdAlumno.Text != "")
            {
                AdminPago dato = new AdminPago(lblUser.Text, int.Parse(data_alumnos.CurrentRow.Cells[0].Value.ToString()));
                dato.lbNombre.Text = data_alumnos.CurrentRow.Cells[1].Value.ToString() + " " + data_alumnos.CurrentRow.Cells[2].Value.ToString() + " " + data_alumnos.CurrentRow.Cells[3].Value.ToString();
                dato.txt_id.Text = data_alumnos.CurrentRow.Cells[0].Value.ToString();
                dato.ShowDialog();
            }
            else MessageBox.Show("Por favor, seleccione un registro de alumno");
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (txt_monto_pago.Text == "")
            {
                MessageBox.Show("Seleccione un pago");
            }
            else
            {
                printTicket = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printTicket.PrinterSettings = ps;
                printTicket.PrintPage += imprimir;
                printDialog1.Document = printTicket;
                printDialog1.PrinterSettings = printTicket.PrinterSettings;
                printDialog1.AllowSomePages = true;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printTicket.PrinterSettings = printDialog1.PrinterSettings;
                    printTicket.Print();
                }
            }
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            if (lblUser.Text != "Admin")
            {
                AdminClasesNA adminClases = new AdminClasesNA();
                adminClases.ShowDialog();
            } else
            {
                AdminClases adminClases = new AdminClases();
                adminClases.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar_tabla_alumno(txtDato.Text);
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Ebrima", 14, FontStyle.Regular, GraphicsUnit.Point);
            Font _enca = new Font("Ebrima", 14, FontStyle.Bold, GraphicsUnit.Point);
            DateTime hoy = DateTime.Parse(data_pagos.CurrentRow.Cells[3].Value.ToString());
            string fecha = hoy.ToString("yyyy/MM/dd");
            string nombre = data_alumnos.CurrentRow.Cells[1].Value.ToString() + " " + data_alumnos.CurrentRow.Cells[2].Value.ToString() + " " + data_alumnos.CurrentRow.Cells[3].Value.ToString();
            string clase = data_pagos.CurrentRow.Cells[0].Value.ToString();
            string Monto = data_pagos.CurrentRow.Cells[1].Value.ToString();
            string concepto = data_pagos.CurrentRow.Cells[2].Value.ToString();

            Image img = Image.FromFile(imagen);
            e.Graphics.DrawImage(img, new RectangleF(50, 20, 200, 80));
            Image img_2 = Image.FromFile(imagen_2);
            e.Graphics.DrawImage(img_2, new RectangleF(90, 100, 120, 120));

            e.Graphics.DrawString("Alumno: ", font, Brushes.Black, new RectangleF(260, 20, 500, 30));
            e.Graphics.DrawString(nombre, _enca, Brushes.Black, new RectangleF(340, 20, 500, 30));

            e.Graphics.DrawString("Clase: ", font, Brushes.Black, new RectangleF(260, 75, 70, 30));
            e.Graphics.DrawString(clase, _enca, Brushes.Black, new RectangleF(320, 75, 330, 30));
            e.Graphics.DrawString("Monto:", font, Brushes.Black, new RectangleF(500, 75, 130, 30));
            e.Graphics.DrawString("$" + Monto, _enca, Brushes.Black, new RectangleF(570, 75, 60, 30));

            e.Graphics.DrawString("Concepto: ", font, Brushes.Black, new RectangleF(260, 130, 170, 30));
            e.Graphics.DrawString(concepto, _enca, Brushes.Black, new RectangleF(360, 130, 150, 30));
            e.Graphics.DrawString("Fecha: ", font, Brushes.Black, new RectangleF(500, 130, 100, 30));
            e.Graphics.DrawString(fecha, _enca, Brushes.Black, new RectangleF(570, 130, 150, 30));

            e.Graphics.DrawString("Le atendió: ", font, Brushes.Black, new RectangleF(260, 185, 170, 30));
            e.Graphics.DrawString(lblUser.Text, _enca, Brushes.Black, new RectangleF(360, 185, 500, 30));
        }
    }
}
