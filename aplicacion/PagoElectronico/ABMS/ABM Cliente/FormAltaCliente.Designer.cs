namespace PagoElectronico.ABM_Cliente
{
    partial class FormAltaCliente
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
            this.groupBoxClienteAlta = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaNac = new System.Windows.Forms.DateTimePicker();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.textBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.labelNacionalidad = new System.Windows.Forms.Label();
            this.groupBoxDomicilio = new System.Windows.Forms.GroupBox();
            this.labelLoc = new System.Windows.Forms.Label();
            this.labelDepto = new System.Windows.Forms.Label();
            this.labelPiso = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.textBoxDepto = new System.Windows.Forms.TextBox();
            this.textBoxLoc = new System.Windows.Forms.TextBox();
            this.comboBoxTiposPais = new System.Windows.Forms.ComboBox();
            this.labelPais = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.buttonGuardarC = new System.Windows.Forms.Button();
            this.buttonLimpiarC = new System.Windows.Forms.Button();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.labelTipoDoc = new System.Windows.Forms.Label();
            this.textBoxPassw = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCancelAlta = new System.Windows.Forms.Button();
            this.groupBoxClienteAlta.SuspendLayout();
            this.groupBoxDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClienteAlta
            // 
            this.groupBoxClienteAlta.AutoSize = true;
            this.groupBoxClienteAlta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxClienteAlta.Controls.Add(this.buttonCancelAlta);
            this.groupBoxClienteAlta.Controls.Add(this.dateTimePickerFechaNac);
            this.groupBoxClienteAlta.Controls.Add(this.labelFechaNac);
            this.groupBoxClienteAlta.Controls.Add(this.textBoxNacionalidad);
            this.groupBoxClienteAlta.Controls.Add(this.labelNacionalidad);
            this.groupBoxClienteAlta.Controls.Add(this.groupBoxDomicilio);
            this.groupBoxClienteAlta.Controls.Add(this.comboBoxTiposPais);
            this.groupBoxClienteAlta.Controls.Add(this.labelPais);
            this.groupBoxClienteAlta.Controls.Add(this.textBoxNumero);
            this.groupBoxClienteAlta.Controls.Add(this.labelNumero);
            this.groupBoxClienteAlta.Controls.Add(this.buttonGuardarC);
            this.groupBoxClienteAlta.Controls.Add(this.buttonLimpiarC);
            this.groupBoxClienteAlta.Controls.Add(this.textBoxMail);
            this.groupBoxClienteAlta.Controls.Add(this.labelMail);
            this.groupBoxClienteAlta.Controls.Add(this.comboBoxRoles);
            this.groupBoxClienteAlta.Controls.Add(this.labelTipoDoc);
            this.groupBoxClienteAlta.Controls.Add(this.textBoxPassw);
            this.groupBoxClienteAlta.Controls.Add(this.labelApellido);
            this.groupBoxClienteAlta.Controls.Add(this.textBoxUsername);
            this.groupBoxClienteAlta.Controls.Add(this.labelName);
            this.groupBoxClienteAlta.Location = new System.Drawing.Point(1, 1);
            this.groupBoxClienteAlta.Name = "groupBoxClienteAlta";
            this.groupBoxClienteAlta.Size = new System.Drawing.Size(699, 480);
            this.groupBoxClienteAlta.TabIndex = 1;
            this.groupBoxClienteAlta.TabStop = false;
            this.groupBoxClienteAlta.Text = "Alta Cliente";
            // 
            // dateTimePickerFechaNac
            // 
            this.dateTimePickerFechaNac.Location = new System.Drawing.Point(464, 133);
            this.dateTimePickerFechaNac.Name = "dateTimePickerFechaNac";
            this.dateTimePickerFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNac.TabIndex = 20;
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Location = new System.Drawing.Point(350, 133);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(108, 13);
            this.labelFechaNac.TabIndex = 19;
            this.labelFechaNac.Text = "Fecha de Nacimiento";
            // 
            // textBoxNacionalidad
            // 
            this.textBoxNacionalidad.Location = new System.Drawing.Point(179, 130);
            this.textBoxNacionalidad.Name = "textBoxNacionalidad";
            this.textBoxNacionalidad.Size = new System.Drawing.Size(136, 20);
            this.textBoxNacionalidad.TabIndex = 18;
            // 
            // labelNacionalidad
            // 
            this.labelNacionalidad.AutoSize = true;
            this.labelNacionalidad.Location = new System.Drawing.Point(67, 133);
            this.labelNacionalidad.Name = "labelNacionalidad";
            this.labelNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.labelNacionalidad.TabIndex = 17;
            this.labelNacionalidad.Text = "Nacionalidad";
            // 
            // groupBoxDomicilio
            // 
            this.groupBoxDomicilio.Controls.Add(this.labelLoc);
            this.groupBoxDomicilio.Controls.Add(this.labelDepto);
            this.groupBoxDomicilio.Controls.Add(this.labelPiso);
            this.groupBoxDomicilio.Controls.Add(this.labelCalle);
            this.groupBoxDomicilio.Controls.Add(this.textBoxCalle);
            this.groupBoxDomicilio.Controls.Add(this.textBoxPiso);
            this.groupBoxDomicilio.Controls.Add(this.textBoxDepto);
            this.groupBoxDomicilio.Controls.Add(this.textBoxLoc);
            this.groupBoxDomicilio.Location = new System.Drawing.Point(70, 221);
            this.groupBoxDomicilio.Name = "groupBoxDomicilio";
            this.groupBoxDomicilio.Size = new System.Drawing.Size(594, 181);
            this.groupBoxDomicilio.TabIndex = 16;
            this.groupBoxDomicilio.TabStop = false;
            this.groupBoxDomicilio.Text = "Domicilio";
            this.groupBoxDomicilio.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelLoc
            // 
            this.labelLoc.AutoSize = true;
            this.labelLoc.Location = new System.Drawing.Point(54, 128);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(53, 13);
            this.labelLoc.TabIndex = 9;
            this.labelLoc.Text = "Localidad";
            // 
            // labelDepto
            // 
            this.labelDepto.AutoSize = true;
            this.labelDepto.Location = new System.Drawing.Point(54, 93);
            this.labelDepto.Name = "labelDepto";
            this.labelDepto.Size = new System.Drawing.Size(74, 13);
            this.labelDepto.TabIndex = 8;
            this.labelDepto.Text = "Departamento";
            // 
            // labelPiso
            // 
            this.labelPiso.AutoSize = true;
            this.labelPiso.Location = new System.Drawing.Point(54, 65);
            this.labelPiso.Name = "labelPiso";
            this.labelPiso.Size = new System.Drawing.Size(27, 13);
            this.labelPiso.TabIndex = 7;
            this.labelPiso.Text = "Piso";
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(54, 35);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(30, 13);
            this.labelCalle.TabIndex = 6;
            this.labelCalle.Text = "Calle";
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(170, 28);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(136, 20);
            this.textBoxCalle.TabIndex = 5;
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(170, 58);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(136, 20);
            this.textBoxPiso.TabIndex = 4;
            // 
            // textBoxDepto
            // 
            this.textBoxDepto.Location = new System.Drawing.Point(170, 90);
            this.textBoxDepto.Name = "textBoxDepto";
            this.textBoxDepto.Size = new System.Drawing.Size(136, 20);
            this.textBoxDepto.TabIndex = 3;
            // 
            // textBoxLoc
            // 
            this.textBoxLoc.Location = new System.Drawing.Point(170, 125);
            this.textBoxLoc.Name = "textBoxLoc";
            this.textBoxLoc.Size = new System.Drawing.Size(136, 20);
            this.textBoxLoc.TabIndex = 2;
            // 
            // comboBoxTiposPais
            // 
            this.comboBoxTiposPais.FormattingEnabled = true;
            this.comboBoxTiposPais.Location = new System.Drawing.Point(179, 176);
            this.comboBoxTiposPais.Name = "comboBoxTiposPais";
            this.comboBoxTiposPais.Size = new System.Drawing.Size(136, 21);
            this.comboBoxTiposPais.TabIndex = 15;
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(67, 179);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(29, 13);
            this.labelPais.TabIndex = 14;
            this.labelPais.Text = "País";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(464, 86);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(136, 20);
            this.textBoxNumero.TabIndex = 13;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(350, 86);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 12;
            this.labelNumero.Text = "Número";
            // 
            // buttonGuardarC
            // 
            this.buttonGuardarC.Location = new System.Drawing.Point(179, 422);
            this.buttonGuardarC.Name = "buttonGuardarC";
            this.buttonGuardarC.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarC.TabIndex = 11;
            this.buttonGuardarC.Text = "Guardar";
            this.buttonGuardarC.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiarC
            // 
            this.buttonLimpiarC.Location = new System.Drawing.Point(70, 422);
            this.buttonLimpiarC.Name = "buttonLimpiarC";
            this.buttonLimpiarC.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarC.TabIndex = 10;
            this.buttonLimpiarC.Text = "Limpiar";
            this.buttonLimpiarC.UseVisualStyleBackColor = true;
            this.buttonLimpiarC.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(464, 181);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(136, 20);
            this.textBoxMail.TabIndex = 9;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(350, 184);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 7;
            this.labelMail.Text = "Mail";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(179, 83);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(136, 21);
            this.comboBoxRoles.TabIndex = 5;
            // 
            // labelTipoDoc
            // 
            this.labelTipoDoc.AutoSize = true;
            this.labelTipoDoc.Location = new System.Drawing.Point(67, 86);
            this.labelTipoDoc.Name = "labelTipoDoc";
            this.labelTipoDoc.Size = new System.Drawing.Size(101, 13);
            this.labelTipoDoc.TabIndex = 4;
            this.labelTipoDoc.Text = "Tipo de Documento";
            // 
            // textBoxPassw
            // 
            this.textBoxPassw.Location = new System.Drawing.Point(464, 38);
            this.textBoxPassw.Name = "textBoxPassw";
            this.textBoxPassw.Size = new System.Drawing.Size(136, 20);
            this.textBoxPassw.TabIndex = 3;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(350, 41);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(179, 38);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(136, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(67, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nombre";
            // 
            // buttonCancelAlta
            // 
            this.buttonCancelAlta.Location = new System.Drawing.Point(589, 422);
            this.buttonCancelAlta.Name = "buttonCancelAlta";
            this.buttonCancelAlta.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAlta.TabIndex = 21;
            this.buttonCancelAlta.Text = "Cancelar";
            this.buttonCancelAlta.UseVisualStyleBackColor = true;
            this.buttonCancelAlta.Click += new System.EventHandler(this.buttonCancelAlta_Click);
            // 
            // FormAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 503);
            this.Controls.Add(this.groupBoxClienteAlta);
            this.Name = "FormAltaCliente";
            this.Text = "Alta Cliente";
            this.groupBoxClienteAlta.ResumeLayout(false);
            this.groupBoxClienteAlta.PerformLayout();
            this.groupBoxDomicilio.ResumeLayout(false);
            this.groupBoxDomicilio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClienteAlta;
        private System.Windows.Forms.Button buttonGuardarC;
        private System.Windows.Forms.Button buttonLimpiarC;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label labelTipoDoc;
        private System.Windows.Forms.TextBox textBoxPassw;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.ComboBox comboBoxTiposPais;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.GroupBox groupBoxDomicilio;
        private System.Windows.Forms.Label labelNacionalidad;
        private System.Windows.Forms.TextBox textBoxNacionalidad;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNac;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.TextBox textBoxDepto;
        private System.Windows.Forms.TextBox textBoxLoc;
        private System.Windows.Forms.Label labelPiso;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.Label labelDepto;
        private System.Windows.Forms.Button buttonCancelAlta;
    }
}