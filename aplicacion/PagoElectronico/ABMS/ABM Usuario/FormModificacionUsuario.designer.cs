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
            this.dateTimePickerUM = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFC = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxUserList = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonNewUsuario = new System.Windows.Forms.Button();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
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
            this.groupBoxUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerUM
            // 
            this.dateTimePickerUM.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerUM.Name = "dateTimePickerUM";
            this.dateTimePickerUM.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerUM.TabIndex = 0;
            // 
            // dateTimePickerFC
            // 
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
            this.groupBoxUserList.AutoSize = true;
            this.groupBoxUserList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxUserList.Controls.Add(this.buttonCancelar);
            this.groupBoxUserList.Controls.Add(this.buttonNewUsuario);
            this.groupBoxUserList.Controls.Add(this.dataGridViewCliente);
            this.groupBoxUserList.Controls.Add(this.groupBoxFiltros);
            this.groupBoxUserList.Location = new System.Drawing.Point(3, 2);
            this.groupBoxUserList.Name = "groupBoxUserList";
            this.groupBoxUserList.Size = new System.Drawing.Size(921, 501);
            this.groupBoxUserList.TabIndex = 1;
            this.groupBoxUserList.TabStop = false;
            this.groupBoxUserList.Text = "Listado Modificacion Usuario";
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
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(36, 186);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.Size = new System.Drawing.Size(632, 228);
            this.dataGridViewCliente.TabIndex = 13;
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.dateTimePickerFechaModif);
            this.groupBoxFiltros.Controls.Add(this.dateTimePickerFechaCrea);
            this.groupBoxFiltros.Controls.Add(this.comboBoxRol);
            this.groupBoxFiltros.Controls.Add(this.buttonBuscarUsuario);
            this.groupBoxFiltros.Controls.Add(this.buttonLimpiarU);
            this.groupBoxFiltros.Controls.Add(this.labelFechaCreac);
            this.groupBoxFiltros.Controls.Add(this.labelFechaModif);
            this.groupBoxFiltros.Controls.Add(this.labelRol);
            this.groupBoxFiltros.Controls.Add(this.labelUserL);
            this.groupBoxFiltros.Controls.Add(this.textBoxUserL);
            this.groupBoxFiltros.Location = new System.Drawing.Point(36, 29);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(632, 141);
            this.groupBoxFiltros.TabIndex = 12;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros de Búsqueda";
            this.groupBoxFiltros.Enter += new System.EventHandler(this.groupBoxFiltros_Enter);
            // 
            // dateTimePickerFechaModif
            // 
            this.dateTimePickerFechaModif.Location = new System.Drawing.Point(411, 56);
            this.dateTimePickerFechaModif.Name = "dateTimePickerFechaModif";
            this.dateTimePickerFechaModif.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaModif.TabIndex = 21;
            // 
            // dateTimePickerFechaCrea
            // 
            this.dateTimePickerFechaCrea.Location = new System.Drawing.Point(411, 19);
            this.dateTimePickerFechaCrea.Name = "dateTimePickerFechaCrea";
            this.dateTimePickerFechaCrea.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaCrea.TabIndex = 20;
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(116, 57);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRol.TabIndex = 19;
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(143, 112);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarUsuario.TabIndex = 11;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = true;
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
            this.labelFechaCreac.Location = new System.Drawing.Point(285, 27);
            this.labelFechaCreac.Name = "labelFechaCreac";
            this.labelFechaCreac.Size = new System.Drawing.Size(82, 13);
            this.labelFechaCreac.TabIndex = 13;
            this.labelFechaCreac.Text = "Fecha Creación";
            // 
            // labelFechaModif
            // 
            this.labelFechaModif.AutoSize = true;
            this.labelFechaModif.Location = new System.Drawing.Point(285, 62);
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
            // FormModificacionUsuario
            // 
            this.ClientSize = new System.Drawing.Size(927, 502);
            this.Controls.Add(this.groupBoxUserList);
            this.Name = "FormModificacionUsuario";
            this.Load += new System.EventHandler(this.FormModificacionUsuario_Load);
            this.groupBoxUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
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


    }
}