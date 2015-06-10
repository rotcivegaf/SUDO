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
            this.labelUserListado = new System.Windows.Forms.Label();
            this.textBoxUserListado = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscarUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerUM = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFC = new System.Windows.Forms.DateTimePicker();
            this.labelDateCreacion = new System.Windows.Forms.Label();
            this.labelDateModif = new System.Windows.Forms.Label();
            this.labelRolAsignado = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxUsuarioList = new System.Windows.Forms.GroupBox();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBoxUsuarioList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserListado
            // 
            this.labelUserListado.AutoSize = true;
            this.labelUserListado.Location = new System.Drawing.Point(34, 27);
            this.labelUserListado.Name = "labelUserListado";
            this.labelUserListado.Size = new System.Drawing.Size(55, 13);
            this.labelUserListado.TabIndex = 7;
            this.labelUserListado.Text = "Username";
            this.labelUserListado.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxUserListado
            // 
            this.textBoxUserListado.Location = new System.Drawing.Point(116, 24);
            this.textBoxUserListado.Name = "textBoxUserListado";
            this.textBoxUserListado.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserListado.TabIndex = 9;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(37, 112);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarUser
            // 
            this.buttonBuscarUser.Location = new System.Drawing.Point(143, 112);
            this.buttonBuscarUser.Name = "buttonBuscarUser";
            this.buttonBuscarUser.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarUser.TabIndex = 11;
            this.buttonBuscarUser.Text = "Usuario";
            this.buttonBuscarUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerUM);
            this.groupBox1.Controls.Add(this.buttonBuscarUser);
            this.groupBox1.Controls.Add(this.dateTimePickerFC);
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.labelDateCreacion);
            this.groupBox1.Controls.Add(this.labelDateModif);
            this.groupBox1.Controls.Add(this.labelRolAsignado);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labelUserListado);
            this.groupBox1.Controls.Add(this.textBoxUserListado);
            this.groupBox1.Location = new System.Drawing.Point(36, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 141);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // dateTimePickerUM
            // 
            this.dateTimePickerUM.Location = new System.Drawing.Point(411, 60);
            this.dateTimePickerUM.Name = "dateTimePickerUM";
            this.dateTimePickerUM.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerUM.TabIndex = 15;
            // 
            // dateTimePickerFC
            // 
            this.dateTimePickerFC.Location = new System.Drawing.Point(411, 24);
            this.dateTimePickerFC.Name = "dateTimePickerFC";
            this.dateTimePickerFC.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFC.TabIndex = 14;
            this.dateTimePickerFC.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelDateCreacion
            // 
            this.labelDateCreacion.AutoSize = true;
            this.labelDateCreacion.Location = new System.Drawing.Point(285, 27);
            this.labelDateCreacion.Name = "labelDateCreacion";
            this.labelDateCreacion.Size = new System.Drawing.Size(82, 13);
            this.labelDateCreacion.TabIndex = 13;
            this.labelDateCreacion.Text = "Fecha Creación";
            // 
            // labelDateModif
            // 
            this.labelDateModif.AutoSize = true;
            this.labelDateModif.Location = new System.Drawing.Point(285, 62);
            this.labelDateModif.Name = "labelDateModif";
            this.labelDateModif.Size = new System.Drawing.Size(119, 13);
            this.labelDateModif.TabIndex = 12;
            this.labelDateModif.Text = "Fecha Ult. Modificacion";
            this.labelDateModif.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelRolAsignado
            // 
            this.labelRolAsignado.AutoSize = true;
            this.labelRolAsignado.Location = new System.Drawing.Point(34, 62);
            this.labelRolAsignado.Name = "labelRolAsignado";
            this.labelRolAsignado.Size = new System.Drawing.Size(70, 13);
            this.labelRolAsignado.TabIndex = 11;
            this.labelRolAsignado.Text = "Rol Asignado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBoxUsuarioList
            // 
            this.groupBoxUsuarioList.AutoSize = true;
            this.groupBoxUsuarioList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxUsuarioList.Controls.Add(this.buttonNewUser);
            this.groupBoxUsuarioList.Controls.Add(this.dataGridView1);
            this.groupBoxUsuarioList.Controls.Add(this.groupBox1);
            this.groupBoxUsuarioList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUsuarioList.Name = "groupBoxUsuarioList";
            this.groupBoxUsuarioList.Size = new System.Drawing.Size(708, 471);
            this.groupBoxUsuarioList.TabIndex = 0;
            this.groupBoxUsuarioList.TabStop = false;
            this.groupBoxUsuarioList.Text = "Listado Modificacion Usuario";
            this.groupBoxUsuarioList.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(593, 429);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(75, 23);
            this.buttonNewUser.TabIndex = 14;
            this.buttonNewUser.Text = "Nuevo";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 228);
            this.dataGridView1.TabIndex = 13;
            // 
            // FormModificacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(724, 470);
            this.Controls.Add(this.groupBoxUsuarioList);
            this.Name = "FormModificacionUsuario";
            this.Text = "ABM Usuario";
            this.Load += new System.EventHandler(this.FormAltaUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxUsuarioList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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


    }
}