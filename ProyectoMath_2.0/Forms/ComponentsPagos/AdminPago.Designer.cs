
namespace ProyectoMath_2._0.Forms.ComponentsPagos
{
    partial class AdminPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPago));
            this.dATOSpagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnModi_clase = new System.Windows.Forms.Button();
            this.btn_inscribir = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.txt_id_pagoModificado = new System.Windows.Forms.TextBox();
            this.txtAdeudo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.Label();
            this.txtCosto_clase = new System.Windows.Forms.Label();
            this.txt_id_inscripcion = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printTicket = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.data_clases = new System.Windows.Forms.DataGridView();
            this.idinscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATOSinscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCom = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.ComboBox();
            this.btn_eliminar_inscripcion = new System.Windows.Forms.Button();
            this.data_pagos_consulta = new System.Windows.Forms.DataGridView();
            this.nombreclaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adeudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblAdeudoOriginal = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSpagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_clases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSinscripcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_pagos_consulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dATOSpagosBindingSource
            // 
            this.dATOSpagosBindingSource.DataSource = typeof(DataAccess.PagosDao);
            // 
            // btnModi_clase
            // 
            this.btnModi_clase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(151)))), ((int)(((byte)(23)))));
            this.btnModi_clase.FlatAppearance.BorderSize = 0;
            this.btnModi_clase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModi_clase.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModi_clase.ForeColor = System.Drawing.Color.White;
            this.btnModi_clase.Location = new System.Drawing.Point(351, 684);
            this.btnModi_clase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModi_clase.Name = "btnModi_clase";
            this.btnModi_clase.Size = new System.Drawing.Size(100, 60);
            this.btnModi_clase.TabIndex = 31;
            this.btnModi_clase.Text = "Modificar inscripción";
            this.btnModi_clase.UseVisualStyleBackColor = false;
            this.btnModi_clase.Click += new System.EventHandler(this.btnModi_clase_Click);
            // 
            // btn_inscribir
            // 
            this.btn_inscribir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btn_inscribir.FlatAppearance.BorderSize = 0;
            this.btn_inscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscribir.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inscribir.ForeColor = System.Drawing.Color.Black;
            this.btn_inscribir.Location = new System.Drawing.Point(206, 684);
            this.btn_inscribir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_inscribir.Name = "btn_inscribir";
            this.btn_inscribir.Size = new System.Drawing.Size(100, 60);
            this.btn_inscribir.TabIndex = 30;
            this.btn_inscribir.Text = "Nueva inscripción";
            this.btn_inscribir.UseVisualStyleBackColor = false;
            this.btn_inscribir.Click += new System.EventHandler(this.btn_inscribir_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(70, 684);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(90, 60);
            this.btn_cerrar.TabIndex = 29;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // txt_id_pagoModificado
            // 
            this.txt_id_pagoModificado.Location = new System.Drawing.Point(554, 15);
            this.txt_id_pagoModificado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id_pagoModificado.Name = "txt_id_pagoModificado";
            this.txt_id_pagoModificado.Size = new System.Drawing.Size(66, 29);
            this.txt_id_pagoModificado.TabIndex = 37;
            this.txt_id_pagoModificado.Visible = false;
            // 
            // txtAdeudo
            // 
            this.txtAdeudo.AutoSize = true;
            this.txtAdeudo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAdeudo.Location = new System.Drawing.Point(129, 618);
            this.txtAdeudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAdeudo.Name = "txtAdeudo";
            this.txtAdeudo.Size = new System.Drawing.Size(41, 21);
            this.txtAdeudo.TabIndex = 35;
            this.txtAdeudo.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 618);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Adeudo:       $";
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Location = new System.Drawing.Point(382, 18);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(25, 21);
            this.txt_id.TabIndex = 33;
            this.txt_id.Text = "ID";
            this.txt_id.Visible = false;
            // 
            // txtCosto_clase
            // 
            this.txtCosto_clase.AutoSize = true;
            this.txtCosto_clase.Location = new System.Drawing.Point(415, 18);
            this.txtCosto_clase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCosto_clase.Name = "txtCosto_clase";
            this.txtCosto_clase.Size = new System.Drawing.Size(50, 21);
            this.txtCosto_clase.TabIndex = 34;
            this.txtCosto_clase.Text = "Costo";
            this.txtCosto_clase.Visible = false;
            // 
            // txt_id_inscripcion
            // 
            this.txt_id_inscripcion.Location = new System.Drawing.Point(475, 15);
            this.txt_id_inscripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id_inscripcion.Name = "txt_id_inscripcion";
            this.txt_id_inscripcion.Size = new System.Drawing.Size(66, 29);
            this.txt_id_inscripcion.TabIndex = 36;
            this.txt_id_inscripcion.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.Location = new System.Drawing.Point(87, 18);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(67, 21);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Alumno";
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAbono.Location = new System.Drawing.Point(350, 345);
            this.txtAbono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(181, 29);
            this.txtAbono.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(378, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad recibida";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(554, 334);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(102, 40);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Aceptar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Historial de pagos";
            // 
            // data_clases
            // 
            this.data_clases.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.data_clases.AllowUserToAddRows = false;
            this.data_clases.AllowUserToDeleteRows = false;
            this.data_clases.AllowUserToResizeColumns = false;
            this.data_clases.AllowUserToResizeRows = false;
            this.data_clases.AutoGenerateColumns = false;
            this.data_clases.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_clases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_clases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_clases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_clases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_clases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinscripcionDataGridViewTextBoxColumn,
            this.nombreclaseDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.idalumnoDataGridViewTextBoxColumn,
            this.idclaseDataGridViewTextBoxColumn});
            this.data_clases.DataSource = this.dATOSinscripcionesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_clases.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_clases.EnableHeadersVisualStyles = false;
            this.data_clases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.data_clases.Location = new System.Drawing.Point(8, 69);
            this.data_clases.MultiSelect = false;
            this.data_clases.Name = "data_clases";
            this.data_clases.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(215)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_clases.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_clases.RowHeadersVisible = false;
            this.data_clases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_clases.Size = new System.Drawing.Size(641, 207);
            this.data_clases.TabIndex = 14;
            this.data_clases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_clases_CellContentClick);
            this.data_clases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_clases_CellContentClick);
            // 
            // idinscripcionDataGridViewTextBoxColumn
            // 
            this.idinscripcionDataGridViewTextBoxColumn.DataPropertyName = "Id_inscripcion";
            this.idinscripcionDataGridViewTextBoxColumn.HeaderText = "Id_inscripcion";
            this.idinscripcionDataGridViewTextBoxColumn.Name = "idinscripcionDataGridViewTextBoxColumn";
            this.idinscripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idinscripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreclaseDataGridViewTextBoxColumn
            // 
            this.nombreclaseDataGridViewTextBoxColumn.DataPropertyName = "Nombre_clase";
            this.nombreclaseDataGridViewTextBoxColumn.HeaderText = "Clase";
            this.nombreclaseDataGridViewTextBoxColumn.Name = "nombreclaseDataGridViewTextBoxColumn";
            this.nombreclaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreclaseDataGridViewTextBoxColumn.Width = 150;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoDataGridViewTextBoxColumn.Width = 90;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 120;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentarioDataGridViewTextBoxColumn.Width = 280;
            // 
            // idalumnoDataGridViewTextBoxColumn
            // 
            this.idalumnoDataGridViewTextBoxColumn.DataPropertyName = "Id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.HeaderText = "Id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.Name = "idalumnoDataGridViewTextBoxColumn";
            this.idalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idalumnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idclaseDataGridViewTextBoxColumn
            // 
            this.idclaseDataGridViewTextBoxColumn.DataPropertyName = "Id_clase";
            this.idclaseDataGridViewTextBoxColumn.HeaderText = "Id_clase";
            this.idclaseDataGridViewTextBoxColumn.Name = "idclaseDataGridViewTextBoxColumn";
            this.idclaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclaseDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATOSinscripcionesBindingSource
            // 
            this.dATOSinscripcionesBindingSource.DataSource = typeof(DataAccess.InscripcionesDao);
            // 
            // txtCom
            // 
            this.txtCom.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCom.Location = new System.Drawing.Point(350, 485);
            this.txtCom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCom.Multiline = true;
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(181, 120);
            this.txtCom.TabIndex = 18;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_limpiar.ForeColor = System.Drawing.Color.Black;
            this.btn_limpiar.Location = new System.Drawing.Point(554, 409);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(102, 40);
            this.btn_limpiar.TabIndex = 19;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(554, 485);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(102, 40);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(391, 455);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Comentario";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(220)))), ((int)(((byte)(111)))));
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_imprimir.ForeColor = System.Drawing.Color.Black;
            this.btn_imprimir.Location = new System.Drawing.Point(554, 565);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(102, 40);
            this.btn_imprimir.TabIndex = 25;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(401, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Concepto";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(310, 18);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 21);
            this.lblUser.TabIndex = 29;
            this.lblUser.Text = "Usuario";
            this.lblUser.Visible = false;
            // 
            // txtConcepto
            // 
            this.txtConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtConcepto.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConcepto.FormattingEnabled = true;
            this.txtConcepto.Items.AddRange(new object[] {
            "Abono",
            "Liquidación"});
            this.txtConcepto.Location = new System.Drawing.Point(350, 416);
            this.txtConcepto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(181, 29);
            this.txtConcepto.TabIndex = 27;
            // 
            // btn_eliminar_inscripcion
            // 
            this.btn_eliminar_inscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.btn_eliminar_inscripcion.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_inscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_inscripcion.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar_inscripcion.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_inscripcion.Location = new System.Drawing.Point(486, 682);
            this.btn_eliminar_inscripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_eliminar_inscripcion.Name = "btn_eliminar_inscripcion";
            this.btn_eliminar_inscripcion.Size = new System.Drawing.Size(100, 60);
            this.btn_eliminar_inscripcion.TabIndex = 30;
            this.btn_eliminar_inscripcion.Text = "Eliminar inscripción";
            this.btn_eliminar_inscripcion.UseVisualStyleBackColor = false;
            this.btn_eliminar_inscripcion.Click += new System.EventHandler(this.btn_eliminar_inscripcion_Click);
            // 
            // data_pagos_consulta
            // 
            this.data_pagos_consulta.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.data_pagos_consulta.AllowUserToAddRows = false;
            this.data_pagos_consulta.AllowUserToDeleteRows = false;
            this.data_pagos_consulta.AllowUserToResizeColumns = false;
            this.data_pagos_consulta.AllowUserToResizeRows = false;
            this.data_pagos_consulta.AutoGenerateColumns = false;
            this.data_pagos_consulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_pagos_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_pagos_consulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_pagos_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_pagos_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_pagos_consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreclaseDataGridViewTextBoxColumn1,
            this.montoDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn1,
            this.comentarioDataGridViewTextBoxColumn1,
            this.adeudoDataGridViewTextBoxColumn,
            this.idpagoDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.data_pagos_consulta.DataSource = this.dATOSpagosBindingSource;
            this.data_pagos_consulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_pagos_consulta.EnableHeadersVisualStyles = false;
            this.data_pagos_consulta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.data_pagos_consulta.Location = new System.Drawing.Point(8, 319);
            this.data_pagos_consulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.data_pagos_consulta.MultiSelect = false;
            this.data_pagos_consulta.Name = "data_pagos_consulta";
            this.data_pagos_consulta.ReadOnly = true;
            this.data_pagos_consulta.RowHeadersVisible = false;
            this.data_pagos_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_pagos_consulta.Size = new System.Drawing.Size(323, 286);
            this.data_pagos_consulta.TabIndex = 31;
            this.data_pagos_consulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_pagos_consulta_CellContentClick);
            // 
            // nombreclaseDataGridViewTextBoxColumn1
            // 
            this.nombreclaseDataGridViewTextBoxColumn1.DataPropertyName = "Nombre_clase";
            this.nombreclaseDataGridViewTextBoxColumn1.HeaderText = "Nombre_clase";
            this.nombreclaseDataGridViewTextBoxColumn1.Name = "nombreclaseDataGridViewTextBoxColumn1";
            this.nombreclaseDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreclaseDataGridViewTextBoxColumn1.Visible = false;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            this.conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            this.conceptoDataGridViewTextBoxColumn.Width = 110;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            this.fechaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn1.Width = 110;
            // 
            // comentarioDataGridViewTextBoxColumn1
            // 
            this.comentarioDataGridViewTextBoxColumn1.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn1.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn1.Name = "comentarioDataGridViewTextBoxColumn1";
            this.comentarioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.comentarioDataGridViewTextBoxColumn1.Visible = false;
            // 
            // adeudoDataGridViewTextBoxColumn
            // 
            this.adeudoDataGridViewTextBoxColumn.DataPropertyName = "Adeudo";
            this.adeudoDataGridViewTextBoxColumn.HeaderText = "Adeudo";
            this.adeudoDataGridViewTextBoxColumn.Name = "adeudoDataGridViewTextBoxColumn";
            this.adeudoDataGridViewTextBoxColumn.ReadOnly = true;
            this.adeudoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpagoDataGridViewTextBoxColumn
            // 
            this.idpagoDataGridViewTextBoxColumn.DataPropertyName = "Id_pago";
            this.idpagoDataGridViewTextBoxColumn.HeaderText = "Id_pago";
            this.idpagoDataGridViewTextBoxColumn.Name = "idpagoDataGridViewTextBoxColumn";
            this.idpagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpagoDataGridViewTextBoxColumn.Visible = false;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.data_pagos_consulta);
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.txtAdeudo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.txt_id_pagoModificado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txtCom);
            this.groupBox1.Controls.Add(this.txtCosto_clase);
            this.groupBox1.Controls.Add(this.data_clases);
            this.groupBox1.Controls.Add(this.txt_id_inscripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAbono);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(11, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(666, 676);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.Location = new System.Drawing.Point(7, 651);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(101, 17);
            this.lblError.TabIndex = 38;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // lblAdeudoOriginal
            // 
            this.lblAdeudoOriginal.AutoSize = true;
            this.lblAdeudoOriginal.Location = new System.Drawing.Point(627, 704);
            this.lblAdeudoOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdeudoOriginal.Name = "lblAdeudoOriginal";
            this.lblAdeudoOriginal.Size = new System.Drawing.Size(28, 15);
            this.lblAdeudoOriginal.TabIndex = 39;
            this.lblAdeudoOriginal.Text = "0.00";
            this.lblAdeudoOriginal.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre_clase";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clase";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Comentario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Comentario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 280;
            // 
            // AdminPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 751);
            this.Controls.Add(this.lblAdeudoOriginal);
            this.Controls.Add(this.btnModi_clase);
            this.Controls.Add(this.btn_eliminar_inscripcion);
            this.Controls.Add(this.btn_inscribir);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar pagos";
            this.Load += new System.EventHandler(this.AdminPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dATOSpagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_clases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSinscripcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_pagos_consulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModi_clase;
        private System.Windows.Forms.Button btn_inscribir;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TextBox txt_id_pagoModificado;
        private System.Windows.Forms.Label txtAdeudo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label txtCosto_clase;
        private System.Windows.Forms.TextBox txt_id_inscripcion;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printTicket;
        private System.Windows.Forms.BindingSource dATOSpagosBindingSource;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data_clases;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox txtConcepto;
        private System.Windows.Forms.Button btn_eliminar_inscripcion;
        private System.Windows.Forms.DataGridView data_pagos_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adeudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblAdeudoOriginal;
        private System.Windows.Forms.BindingSource dATOSinscripcionesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclaseDataGridViewTextBoxColumn;
    }
}