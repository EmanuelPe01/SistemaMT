
namespace ProyectoMath_2._0.Forms.ComponentsPagos
{
    partial class AdminClases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminClases));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.dataClases = new System.Windows.Forms.DataGridView();
            this.idclaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATOSclasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSclasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 158);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registre o modifique una clase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de \r\nla clase\r\n";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(134, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Costo            $";
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCosto.Location = new System.Drawing.Point(134, 110);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(242, 26);
            this.txtCosto.TabIndex = 7;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(188)))), ((int)(((byte)(66)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_guardar.Location = new System.Drawing.Point(305, 327);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 40);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_limpiar.Location = new System.Drawing.Point(158, 327);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(110, 40);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Cancelar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // dataClases
            // 
            this.dataClases.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataClases.AllowUserToAddRows = false;
            this.dataClases.AllowUserToDeleteRows = false;
            this.dataClases.AllowUserToResizeColumns = false;
            this.dataClases.AllowUserToResizeRows = false;
            this.dataClases.AutoGenerateColumns = false;
            this.dataClases.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataClases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataClases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclaseDataGridViewTextBoxColumn,
            this.nombreclaseDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn});
            this.dataClases.DataSource = this.dATOSclasesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataClases.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataClases.EnableHeadersVisualStyles = false;
            this.dataClases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.dataClases.Location = new System.Drawing.Point(434, 24);
            this.dataClases.Name = "dataClases";
            this.dataClases.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClases.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataClases.RowHeadersVisible = false;
            this.dataClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClases.Size = new System.Drawing.Size(331, 346);
            this.dataClases.TabIndex = 19;
            this.dataClases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClases_CellContentClick);
            this.dataClases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClases_CellContentClick);
            // 
            // idclaseDataGridViewTextBoxColumn
            // 
            this.idclaseDataGridViewTextBoxColumn.DataPropertyName = "Id_clase";
            this.idclaseDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idclaseDataGridViewTextBoxColumn.Name = "idclaseDataGridViewTextBoxColumn";
            this.idclaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclaseDataGridViewTextBoxColumn.Width = 30;
            // 
            // nombreclaseDataGridViewTextBoxColumn
            // 
            this.nombreclaseDataGridViewTextBoxColumn.DataPropertyName = "Nombre_clase";
            this.nombreclaseDataGridViewTextBoxColumn.HeaderText = "Nombre de la clase";
            this.nombreclaseDataGridViewTextBoxColumn.Name = "nombreclaseDataGridViewTextBoxColumn";
            this.nombreclaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreclaseDataGridViewTextBoxColumn.Width = 200;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATOSclasesBindingSource
            // 
            this.dATOSclasesBindingSource.DataSource = typeof(DataAccess.ClasesDao);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(315, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 18;
            this.txtID.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cerrar.Location = new System.Drawing.Point(12, 327);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(110, 40);
            this.btn_cerrar.TabIndex = 17;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.Location = new System.Drawing.Point(12, 262);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(101, 17);
            this.lblError.TabIndex = 39;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Buscar por nombre";
            // 
            // txtClase
            // 
            this.txtClase.Location = new System.Drawing.Point(12, 56);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(297, 29);
            this.txtClase.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(136)))), ((int)(((byte)(196)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(315, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 42;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.dataClases);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btn_cerrar);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminClases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clases";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSclasesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.DataGridView dataClases;
        private System.Windows.Forms.BindingSource dATOSclasesBindingSource;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.Button button1;
    }
}