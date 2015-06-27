namespace PagoElectronico.ABM_Usuario
{
    partial class FormModificacionUsuario
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
            System.Windows.Forms.GroupBox groupBoxFiltros;
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkFechaModf = new System.Windows.Forms.CheckBox();
            this.checkFechaC = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFechaModif = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaCrea = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.buttonLimpiarU = new System.Windows.Forms.Button();
            this.labelFechaCreac = new System.Windows.Forms.Label();
            this.labelFechaModif = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelUserL = new System.Windows.Forms.Label();
            this.textBoxUserL = new System.Windows.Forms.TextBox();
            this.dateTimePickerUM = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFC = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxUserList = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonNewUsuario = new System.Windows.Forms.Button();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            groupBoxFiltros = new System.Windows.Forms.GroupBox();
            groupBoxFiltros.SuspendLayout();
            this.groupBoxUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            groupBoxFiltros.Controls.Add(this.label2);
            groupBoxFiltros.Controls.Add(this.label1);
            groupBoxFiltros.Controls.Add(this.checkFechaModf);
            groupBoxFiltros.Controls.Add(this.checkFechaC);
            groupBoxFiltros.Controls.Add(this.dateTimePickerFechaModif);
            groupBoxFiltros.Controls.Add(this.dateTimePickerFechaCrea);
            groupBoxFiltros.Controls.Add(this.comboBoxRol);
            groupBoxFiltros.Controls.Add(this.buttonBuscarUsuario);
            groupBoxFiltros.Controls.Add(this.buttonLimpiarU);
            groupBoxFiltros.Controls.Add(this.labelFechaCreac);
            groupBoxFiltros.Controls.Add(this.labelFechaModif);
            groupBoxFiltros.Controls.Add(this.labelRol);
            groupBoxFiltros.Controls.Add(this.labelUserL);
            groupBoxFiltros.Controls.Add(this.textBoxUserL);
            groupBoxFiltros.Location = new System.Drawing.Point(36, 29);
            groupBoxFiltros.Name = "groupBoxFiltros";
            groupBoxFiltros.Size = new System.Drawing.Size(810, 141);
            groupBoxFiltros.TabIndex = 12;
            groupBoxFiltros.TabStop = false;
            groupBoxFiltros.Text = "Filtros de Búsqueda";
            groupBoxFiltros.Enter += new System.EventHandler(this.groupBoxFiltros_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sin Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sin Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // checkFechaModf
            // 
            this.checkFechaModf.AutoSize = true;
            this.checkFechaModf.Location = new System.Drawing.Point(409, 62);
            this.checkFechaModf.Name = "checkFechaModf";
            this.checkFechaModf.Size = new System.Drawing.Size(15, 14);
            this.checkFechaModf.TabIndex = 23;
            this.checkFechaModf.UseVisualStyleBackColor = true;
            this.checkFechaModf.CheckedChanged += new System.EventHandler(this.checkFechaModf_CheckedChanged);
            // 
            // checkFechaC
            // 
            this.checkFechaC.AutoSize = true;
            this.checkFechaC.Location = new System.Drawing.Point(409, 30);
            this.checkFechaC.Name = "checkFechaC";
            this.checkFechaC.Size = new System.Drawing.Size(15, 14);
            this.checkFechaC.TabIndex = 22;
            this.checkFechaC.UseVisualStyleBackColor = true;
            this.checkFechaC.CheckedChanged += new System.EventHandler(this.checkFechaC_CheckedChanged);
            // 
            // dateTimePickerFechaModif
            // 
            this.dateTimePickerFechaModif.CustomFormat = "";
            this.dateTimePickerFechaModif.Location = new System.Drawing.Point(554, 56);
            this.dateTimePickerFechaModif.Name = "dateTimePickerFechaModif";
            this.dateTimePickerFechaModif.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerFechaModif.TabIndex = 21;
            // 
            // dateTimePickerFechaCrea
            // 
            this.dateTimePickerFechaCrea.Location = new System.Drawing.Point(554, 24);
            this.dateTimePickerFechaCrea.Name = "dateTimePickerFechaCrea";
            this.dateTimePickerFechaCrea.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerFechaCrea.TabIndex = 20;
            this.dateTimePickerFechaCrea.Value = new System.DateTime(2015, 6, 17, 2, 52, 8, 0);
            this.dateTimePickerFechaCrea.ValueChanged += new System.EventHandler(this.dateTimePickerFechaCrea_ValueChanged);
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(116, 57);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRol.TabIndex = 19;
            this.comboBoxRol.SelectedIndexChanged += new System.EventHandler(this.comboBoxRol_SelectedIndexChanged);
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(143, 112);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarUsuario.TabIndex = 11;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = true;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // buttonLimpiarU
            // 
            this.buttonLimpiarU.Location = new System.Drawing.Point(37, 112);
            this.buttonLimpiarU.Name = "buttonLimpiarU";
            this.buttonLimpiarU.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarU.TabIndex = 10;
            this.buttonLimpiarU.Text = "Limpiar";
            this.buttonLimpiarU.UseVisualStyleBackColor = true;
            // 
            // labelFechaCreac
            // 
            this.labelFechaCreac.AutoSize = true;
            this.labelFechaCreac.Location = new System.Drawing.Point(447, 30);
            this.labelFechaCreac.Name = "labelFechaCreac";
            this.labelFechaCreac.Size = new System.Drawing.Size(82, 13);
            this.labelFechaCreac.TabIndex = 13;
            this.labelFechaCreac.Text = "Fecha Creación";
            // 
            // labelFechaModif
            // 
            this.labelFechaModif.AutoSize = true;
            this.labelFechaModif.Location = new System.Drawing.Point(447, 62);
            this.labelFechaModif.Name = "labelFechaModif";
            this.labelFechaModif.Size = new System.Drawing.Size(88, 13);
            this.labelFechaModif.TabIndex = 12;
            this.labelFechaModif.Text = "Fecha Ult. Modif.";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(34, 62);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(70, 13);
            this.labelRol.TabIndex = 11;
            this.labelRol.Text = "Rol Asignado";
            // 
            // labelUserL
            // 
            this.labelUserL.AutoSize = true;
            this.labelUserL.Location = new System.Drawing.Point(34, 27);
            this.labelUserL.Name = "labelUserL";
            this.labelUserL.Size = new System.Drawing.Size(55, 13);
            this.labelUserL.TabIndex = 7;
            this.labelUserL.Text = "Username";
            // 
            // textBoxUserL
            // 
            this.textBoxUserL.Location = new System.Drawing.Point(116, 24);
            this.textBoxUserL.Name = "textBoxUserL";
            this.textBoxUserL.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserL.TabIndex = 9;
            // 
            // dateTimePickerUM
            // 
            this.dateTimePickerUM.CustomFormat = "";
            this.dateTimePickerUM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerUM.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerUM.Name = "dateTimePickerUM";
            this.dateTimePickerUM.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerUM.TabIndex = 0;
            // 
            // dateTimePickerFC
            // 
            this.dateTimePickerFC.CustomFormat = "";
            this.dateTimePickerFC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerFC.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerFC.Name = "dateTimePickerFC";
            this.dateTimePickerFC.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFC.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBoxUserList
            // 
            this.groupBoxUserList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxUserList.AutoSize = true;
            this.groupBoxUserList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxUserList.Controls.Add(this.buttonCancelar);
            this.groupBoxUserList.Controls.Add(this.buttonNewUsuario);
            this.groupBoxUserList.Controls.Add(this.dataGridViewUsuario);
            this.groupBoxUserList.Controls.Add(groupBoxFiltros);
            this.groupBoxUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxUserList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxUserList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUserList.Name = "groupBoxUserList";
            this.groupBoxUserList.Size = new System.Drawing.Size(950, 501);
            this.groupBoxUserList.TabIndex = 1;
            this.groupBoxUserList.TabStop = false;
            this.groupBoxUserList.Text = "Listado Modificacion Usuario";
            this.groupBoxUserList.Enter += new System.EventHandler(this.groupBoxUserList_Enter);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(152, 445);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonNewUsuario
            // 
            this.buttonNewUsuario.Location = new System.Drawing.Point(36, 445);
            this.buttonNewUsuario.Name = "buttonNewUsuario";
            this.buttonNewUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonNewUsuario.TabIndex = 14;
            this.buttonNewUsuario.Text = "Nuevo";
            this.buttonNewUsuario.UseVisualStyleBackColor = true;
            this.buttonNewUsuario.Click += new System.EventHandler(this.buttonNewUsuario_Click);
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToAddRows = false;
            this.dataGridViewUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsuario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.select});
            this.dataGridViewUsuario.Location = new System.Drawing.Point(36, 186);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.Size = new System.Drawing.Size(810, 228);
            this.dataGridViewUsuario.TabIndex = 13;
            this.dataGridViewUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuario_CellContentClick);
            // 
            // delete
            // 
            this.delete.HeaderText = "Eliminar";
            this.delete.Name = "delete";
            this.delete.Text = "Eliminar";
            this.delete.UseColumnTextForLinkValue = true;
            // 
            // select
            // 
            this.select.HeaderText = "Seleccionar";
            this.select.Name = "select";
            this.select.Text = "Seleccionar";
            this.select.UseColumnTextForButtonValue = true;
            // 
            // FormModificacionUsuario
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 502);
            this.Controls.Add(this.groupBoxUserList);
            this.Name = "FormModificacionUsuario";
            this.Text = "Listado Usuarios / Modificacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormModificacionUsuario_Load);
            groupBoxFiltros.ResumeLayout(false);
            groupBoxFiltros.PerformLayout();
            this.groupBoxUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserListado;
        private System.Windows.Forms.TextBox textBoxUserListado;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscarUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxUsuarioList;
        private System.Windows.Forms.Label labelRolAsignado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDateCreacion;
        private System.Windows.Forms.Label labelDateModif;
        private System.Windows.Forms.DateTimePicker dateTimePickerFC;
        private System.Windows.Forms.DateTimePicker dateTimePickerUM;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxUserList;
        private System.Windows.Forms.Button buttonNewUsuario;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.Button buttonLimpiarU;
        private System.Windows.Forms.Label labelFechaCreac;
        private System.Windows.Forms.Label labelFechaModif;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelUserL;
        private System.Windows.Forms.TextBox textBoxUserL;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCrea;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaModif;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.CheckBox checkFechaModf;
        private System.Windows.Forms.CheckBox checkFechaC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewLinkColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn select;


    }
}