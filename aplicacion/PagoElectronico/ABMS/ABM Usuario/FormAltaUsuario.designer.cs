namespace PagoElectronico.ABM_Usuario
{
    partial class FormAltaUsuario
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
            this.groupBoxUsuarioAlta = new System.Windows.Forms.GroupBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxRtaSecreta = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelRtaSecreta = new System.Windows.Forms.Label();
            this.labelPregSecreta = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.textBoxPassw = new System.Windows.Forms.TextBox();
            this.labelPassw = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonCancelAltaUser = new System.Windows.Forms.Button();
            this.groupBoxUsuarioAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUsuarioAlta
            // 
            this.groupBoxUsuarioAlta.AutoSize = true;
            this.groupBoxUsuarioAlta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxUsuarioAlta.Controls.Add(this.buttonCancelAltaUser);
            this.groupBoxUsuarioAlta.Controls.Add(this.buttonGuardar);
            this.groupBoxUsuarioAlta.Controls.Add(this.buttonLimpiar);
            this.groupBoxUsuarioAlta.Controls.Add(this.textBoxRtaSecreta);
            this.groupBoxUsuarioAlta.Controls.Add(this.comboBox1);
            this.groupBoxUsuarioAlta.Controls.Add(this.labelRtaSecreta);
            this.groupBoxUsuarioAlta.Controls.Add(this.labelPregSecreta);
            this.groupBoxUsuarioAlta.Controls.Add(this.comboBoxRoles);
            this.groupBoxUsuarioAlta.Controls.Add(this.labelRol);
            this.groupBoxUsuarioAlta.Controls.Add(this.textBoxPassw);
            this.groupBoxUsuarioAlta.Controls.Add(this.labelPassw);
            this.groupBoxUsuarioAlta.Controls.Add(this.textBoxUsername);
            this.groupBoxUsuarioAlta.Controls.Add(this.labelUsername);
            this.groupBoxUsuarioAlta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUsuarioAlta.Name = "groupBoxUsuarioAlta";
            this.groupBoxUsuarioAlta.Size = new System.Drawing.Size(685, 492);
            this.groupBoxUsuarioAlta.TabIndex = 0;
            this.groupBoxUsuarioAlta.TabStop = false;
            this.groupBoxUsuarioAlta.Text = "Alta Usuario";
            this.groupBoxUsuarioAlta.Enter += new System.EventHandler(this.groupBoxUsuarioAlta_Enter);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(142, 428);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 11;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(36, 428);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // textBoxRtaSecreta
            // 
            this.textBoxRtaSecreta.Location = new System.Drawing.Point(142, 190);
            this.textBoxRtaSecreta.Name = "textBoxRtaSecreta";
            this.textBoxRtaSecreta.Size = new System.Drawing.Size(169, 20);
            this.textBoxRtaSecreta.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelRtaSecreta
            // 
            this.labelRtaSecreta.AutoSize = true;
            this.labelRtaSecreta.Location = new System.Drawing.Point(33, 193);
            this.labelRtaSecreta.Name = "labelRtaSecreta";
            this.labelRtaSecreta.Size = new System.Drawing.Size(98, 13);
            this.labelRtaSecreta.TabIndex = 7;
            this.labelRtaSecreta.Text = "Respuesta Secreta";
            this.labelRtaSecreta.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPregSecreta
            // 
            this.labelPregSecreta.AutoSize = true;
            this.labelPregSecreta.Location = new System.Drawing.Point(33, 142);
            this.labelPregSecreta.Name = "labelPregSecreta";
            this.labelPregSecreta.Size = new System.Drawing.Size(90, 13);
            this.labelPregSecreta.TabIndex = 6;
            this.labelPregSecreta.Text = "Pregunta Secreta";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(142, 85);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(169, 21);
            this.comboBoxRoles.TabIndex = 5;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(33, 88);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(69, 13);
            this.labelRol.TabIndex = 4;
            this.labelRol.Text = "Rol asignado";
            this.labelRol.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxPassw
            // 
            this.textBoxPassw.Location = new System.Drawing.Point(444, 38);
            this.textBoxPassw.Name = "textBoxPassw";
            this.textBoxPassw.Size = new System.Drawing.Size(160, 20);
            this.textBoxPassw.TabIndex = 3;
            // 
            // labelPassw
            // 
            this.labelPassw.AutoSize = true;
            this.labelPassw.Location = new System.Drawing.Point(362, 41);
            this.labelPassw.Name = "labelPassw";
            this.labelPassw.Size = new System.Drawing.Size(53, 13);
            this.labelPassw.TabIndex = 2;
            this.labelPassw.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(142, 38);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(169, 20);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(33, 41);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCancelAltaUser
            // 
            this.buttonCancelAltaUser.Location = new System.Drawing.Point(529, 428);
            this.buttonCancelAltaUser.Name = "buttonCancelAltaUser";
            this.buttonCancelAltaUser.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAltaUser.TabIndex = 12;
            this.buttonCancelAltaUser.Text = "Cancelar";
            this.buttonCancelAltaUser.UseVisualStyleBackColor = true;
            this.buttonCancelAltaUser.Click += new System.EventHandler(this.buttonCancelAltaUser_Click);
            // 
            // FormAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(709, 505);
            this.Controls.Add(this.groupBoxUsuarioAlta);
            this.Name = "FormAltaUsuario";
            this.Text = "ABM Usuario";
            this.Load += new System.EventHandler(this.FormAltaUsuario_Load);
            this.groupBoxUsuarioAlta.ResumeLayout(false);
            this.groupBoxUsuarioAlta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsuarioAlta;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassw;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.TextBox textBoxPassw;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label labelRtaSecreta;
        private System.Windows.Forms.Label labelPregSecreta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxRtaSecreta;
        private System.Windows.Forms.Button buttonCancelAltaUser;

    }
}