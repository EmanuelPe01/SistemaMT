
namespace ProyectoMath_2._0.Forms
{
    partial class Ingresos
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
            this.dataPagos = new System.Windows.Forms.DataGridView();
            this.Id_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adeudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATOSpagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dateDespues = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateAntes_ = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSpagosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPagos
            // 
            this.dataPagos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataPagos.AllowUserToAddRows = false;
            this.dataPagos.AllowUserToDeleteRows = false;
            this.dataPagos.AllowUserToResizeColumns = false;
            this.dataPagos.AllowUserToResizeRows = false;
            this.dataPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPagos.AutoGenerateColumns = false;
            this.dataPagos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_pago,
            this.nombreclaseDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.User,
            this.comentarioDataGridViewTextBoxColumn,
            this.adeudoDataGridViewTextBoxColumn,
            this.idpagoDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.dataPagos.DataSource = this.dATOSpagosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPagos.EnableHeadersVisualStyles = false;
            this.dataPagos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.dataPagos.Location = new System.Drawing.Point(20, 84);
            this.dataPagos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataPagos.MultiSelect = false;
            this.dataPagos.Name = "dataPagos";
            this.dataPagos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPagos.RowHeadersVisible = false;
            this.dataPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPagos.Size = new System.Drawing.Size(1094, 620);
            this.dataPagos.TabIndex = 6;
            // 
            // Id_pago
            // 
            this.Id_pago.DataPropertyName = "Id_pago";
            this.Id_pago.HeaderText = "ID";
            this.Id_pago.Name = "Id_pago";
            this.Id_pago.ReadOnly = true;
            this.Id_pago.Visible = false;
            this.Id_pago.Width = 30;
            // 
            // nombreclaseDataGridViewTextBoxColumn
            // 
            this.nombreclaseDataGridViewTextBoxColumn.DataPropertyName = "Nombre_clase";
            this.nombreclaseDataGridViewTextBoxColumn.HeaderText = "Nombre de la clase";
            this.nombreclaseDataGridViewTextBoxColumn.Name = "nombreclaseDataGridViewTextBoxColumn";
            this.nombreclaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreclaseDataGridViewTextBoxColumn.Width = 250;
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
            this.conceptoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 150;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "Realizado";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 120;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentarioDataGridViewTextBoxColumn.Width = 400;
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
            // dATOSpagosBindingSource
            // 
            this.dATOSpagosBindingSource.DataSource = typeof(DataAccess.PagosDao);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(102)))), ((int)(((byte)(85)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_buscar.ForeColor = System.Drawing.Color.Snow;
            this.btn_buscar.Location = new System.Drawing.Point(880, 21);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(93, 35);
            this.btn_buscar.TabIndex = 14;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dateDespues
            // 
            this.dateDespues.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDespues.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDespues.Location = new System.Drawing.Point(552, 22);
            this.dateDespues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateDespues.Name = "dateDespues";
            this.dateDespues.Size = new System.Drawing.Size(304, 29);
            this.dateDespues.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(517, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "al";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Del";
            // 
            // dateAntes_
            // 
            this.dateAntes_.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateAntes_.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateAntes_.Location = new System.Drawing.Point(198, 22);
            this.dateAntes_.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateAntes_.Name = "dateAntes_";
            this.dateAntes_.Size = new System.Drawing.Size(304, 29);
            this.dateAntes_.TabIndex = 10;
            // 
            // Ingresos
            // 
            this.AcceptButton = this.btn_buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 716);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dateDespues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateAntes_);
            this.Controls.Add(this.dataPagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.Ingresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSpagosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPagos;
        private System.Windows.Forms.BindingSource dATOSpagosBindingSource;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DateTimePicker dateDespues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateAntes_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adeudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
    }
}