using DataAccess;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoMath_2._0.Forms.ComponentsPagos
{
    public partial class AdminPago : Form
    {
        private string imagen = @"C:\head.jpg", imagen_2 = @"C:\codigo.png";
        public AdminPago(string userName, int idAlumno)
        {
            InitializeComponent();
            cargar_tabla_inscripcion(idAlumno);
            lblUser.Text = userName.ToString();
        }
        private void AdminPago_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        public void cargar_tabla_inscripcion(int dato)
        {
            InscripcionModel _ctrlInscripcion = new InscripcionModel();
            data_clases.DataSource = _ctrlInscripcion.consulta(dato);
        }

        public void cargar_tabla_pagos(int dato, int dato_2)
        {
            PagoModel _ctrlPagos = new PagoModel();
            data_pagos_consulta.DataSource = _ctrlPagos.consulta(dato, dato_2);
        }

        private void data_clases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            double adeudo = 0, d_1 = 0, total = 0; ;
            txt_id_inscripcion.Text = data_clases.CurrentRow.Cells[0].Value.ToString();
            int id_a = int.Parse(txt_id.Text);
            int id_c = int.Parse(data_clases.CurrentRow.Cells[6].Value.ToString());
            txtCosto_clase.Text = data_clases.CurrentRow.Cells[2].Value.ToString();
            cargar_tabla_pagos(id_a, id_c);
            foreach (DataGridViewRow row in data_pagos_consulta.Rows)
            {
                adeudo += Convert.ToDouble(row.Cells["montoDataGridViewTextBoxColumn"].Value);
            }
            d_1 = double.Parse(txtCosto_clase.Text);
            total = d_1 - adeudo;
            txtAdeudo.Text = Convert.ToString(total);
            lblAdeudoOriginal.Text = txtAdeudo.Text;
        }

        private void data_pagos_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double dato = 0, adeudo = 0, d_1 = 0;
            limpiar();
            txt_id_pagoModificado.Text = data_pagos_consulta.CurrentRow.Cells[6].Value.ToString();
            txtAbono.Text = data_pagos_consulta.CurrentRow.Cells[1].Value.ToString();
            txtCom.Text = data_pagos_consulta.CurrentRow.Cells[4].Value.ToString();
            foreach (DataGridViewRow row in data_pagos_consulta.Rows)
            {
                adeudo += Convert.ToDouble(row.Cells["montoDataGridViewTextBoxColumn"].Value);
            }
            d_1 = double.Parse(txtCosto_clase.Text);
            dato = d_1 - adeudo;
            dato += double.Parse(txtAbono.Text);
            txtAdeudo.Text = Convert.ToString(dato);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            double abono;
            PagosDao _newreg = new PagosDao();
            _newreg.Comentario = txtCom.Text;
            string concepto = txtConcepto.Text;
            string user = lblUser.Text;
            int id_alumno = int.Parse(txt_id.Text), id_clase = int.Parse(data_clases.CurrentRow.Cells[6].Value.ToString());
            string alumno = lbNombre.Text;

            PagoModel reg = new PagoModel();

            if (txtAdeudo.Text != "0.00")
            {
                _newreg.Adeudo = double.Parse(txtAdeudo.Text);
                if (txtAbono.Text != "" && concepto != "")
                {
                    if (double.TryParse(txtAbono.Text, out abono))
                    {
                        double dif = _newreg.Adeudo - abono;
                        if (dif >= 0)
                        {
                            if (txt_id_pagoModificado.Text != "")
                            {
                                _newreg.Id_pago = int.Parse(txt_id_pagoModificado.Text);
                                bandera = reg.actualizar(_newreg, id_alumno, id_clase, abono, concepto, user, alumno);
                            }
                            else
                            {
                                bandera = reg.insertar(_newreg, id_alumno, id_clase, abono, concepto, user);
                            }
                            if (bandera)
                            {
                                MessageBox.Show("Registro guardado");
                                double adeudo = 0, d_1 = 0, total = 0; ;
                                int id_a = int.Parse(txt_id.Text);
                                int id_c = int.Parse(data_clases.CurrentRow.Cells[6].Value.ToString());
                                txtCosto_clase.Text = data_clases.CurrentRow.Cells[2].Value.ToString();
                                cargar_tabla_pagos(id_a, id_c);
                                foreach (DataGridViewRow row in data_pagos_consulta.Rows)
                                {
                                    adeudo += Convert.ToDouble(row.Cells["montoDataGridViewTextBoxColumn"].Value);
                                }
                                d_1 = double.Parse(txtCosto_clase.Text);
                                total = d_1 - adeudo;
                                txtAdeudo.Text = Convert.ToString(total);
                                lblAdeudoOriginal.Text = txtAdeudo.Text;
                                limpiar();
                                lblError.Visible = false;
                                if (MessageBox.Show("¿Desea imprimir un recibo?", "Imprimir pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    invocarImprimir();
                            }
                        }
                        else msgError("La cantidad introducida excede el adeudo");
                    }
                    else msgError("Ingrese una candiad válida");
                }
                else msgError("Rellene todos los campos. (Opcional comentario)");
            }
            else msgError("Seleccione una inscripción");

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            string alumno = lbNombre.Text;
            string user = lblUser.Text;
            if (txt_id_pagoModificado.Text != "")
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int id = int.Parse(txt_id_pagoModificado.Text);
                    PagoModel _eliminar = new PagoModel();
                    bandera = _eliminar.eliminar(id, alumno, user);
                    if (bandera)
                    {
                        MessageBox.Show("Registro Eliminado", "Eliminar registro");
                        double adeudo = 0, d_1 = 0, total = 0; ;
                        int id_a = int.Parse(txt_id.Text);
                        int id_c = int.Parse(data_clases.CurrentRow.Cells[6].Value.ToString());
                        txtCosto_clase.Text = data_clases.CurrentRow.Cells[2].Value.ToString();
                        cargar_tabla_pagos(id_a, id_c);
                        foreach (DataGridViewRow row in data_pagos_consulta.Rows)
                        {
                            adeudo += Convert.ToDouble(row.Cells["montoDataGridViewTextBoxColumn"].Value);
                        }
                        d_1 = double.Parse(txtCosto_clase.Text);
                        total = d_1 - adeudo;
                        txtAdeudo.Text = Convert.ToString(total);
                        lblAdeudoOriginal.Text = txtAdeudo.Text;
                        limpiar();
                    }
                }
            }
            else msgError("Seleccione un registro del historial de pagos");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Terminar administración de pagos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Close();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (txt_id_pagoModificado.Text != "")
            {
                invocarImprimir();
                limpiar();
                lblError.Visible = false;
            }
            else msgError("Seleccione un registro del historial de pagos");
        }

        private void btn_eliminar_inscripcion_Click(object sender, EventArgs e)
        {
            string alumno = lbNombre.Text;
            string user = lblUser.Text;
            bool bandera = false;
            if (txt_id_inscripcion.Text != "")
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(txt_id_inscripcion.Text);
                    InscripcionModel eliminar = new InscripcionModel();
                    bandera = eliminar.eliminar_ins(id, alumno, user);
                    if (bandera)
                    {
                        MessageBox.Show("Registro Eliminado", "Eliminar registro");
                        cargar_tabla_inscripcion(int.Parse(txt_id.Text));
                        limpiar();
                        data_pagos_consulta.DataSource = null;
                    }
                }
            }
            else msgError("Seleccione un registro de las clases");
        }

        private void btn_inscribir_Click(object sender, EventArgs e)
        {
            string user = lblUser.Text;
            NewInscripcion n_Clase = new NewInscripcion(user);
            n_Clase.txt_id.Text = txt_id.Text; //Id del alumno
            n_Clase.ShowDialog();
            cargar_tabla_inscripcion(int.Parse(txt_id.Text));
            lblAdeudoOriginal.Text = "0.00";
            limpiar();
            data_pagos_consulta.DataSource = null;
        }

        private void btnModi_clase_Click(object sender, EventArgs e)
        {
            ModInscripcion_ modi_ = new ModInscripcion_();
            modi_.lblIdInscripcion.Text = data_clases.CurrentRow.Cells[0].Value.ToString();
            modi_.txtClase.Text = data_clases.CurrentRow.Cells[1].Value.ToString();
            modi_.txtCosto.Text = data_clases.CurrentRow.Cells[2].Value.ToString();
            modi_.txtComentario.Text = data_clases.CurrentRow.Cells[4].Value.ToString();
            modi_.lblIdAlumno.Text = data_clases.CurrentRow.Cells[5].Value.ToString();
            modi_.txtNombre.Text = lbNombre.Text;
            modi_.txtUser.Text = lblUser.Text;
            modi_.ShowDialog();
            cargar_tabla_inscripcion(int.Parse(txt_id.Text));
            lblAdeudoOriginal.Text = "0.00";
            limpiar();
            data_pagos_consulta.DataSource = null;
        }

        private void invocarImprimir()
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
        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private bool validarCantidad(string Texto)
        {
            double cantidad;
            if (Texto != "" && double.TryParse(Texto, out cantidad))
                return true;
            else
                return false;
        }
        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Ebrima", 14, FontStyle.Regular, GraphicsUnit.Point);
            Font _enca = new Font("Ebrima", 14, FontStyle.Bold, GraphicsUnit.Point);
            DateTime hoy = DateTime.Parse(data_pagos_consulta.CurrentRow.Cells[3].Value.ToString());
            string fecha = hoy.ToString("yyyy/MM/dd");
            string nombre = lbNombre.Text;
            string clase = data_clases.CurrentRow.Cells[1].Value.ToString();
            string Monto = data_pagos_consulta.CurrentRow.Cells[1].Value.ToString();
            string concepto = data_pagos_consulta.CurrentRow.Cells[2].Value.ToString();
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
        private void limpiar()
        {
            txt_id_inscripcion.Text = "";
            txtAbono.Text = "";
            txtCom.Text = "";
            txtConcepto.Text = "";
            txt_id_pagoModificado.Text = "";
            txtAdeudo.Text = lblAdeudoOriginal.Text;
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
    }
}
