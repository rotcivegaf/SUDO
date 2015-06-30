namespace PagoElectronico.ABMS.ABM_Cuenta
{
    partial class FormCuentaAlta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.botomVolver = new System.Windows.Forms.Button();
            this.botomAlta = new System.Windows.Forms.Button();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pais:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Moneda:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(102, 6);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(212, 20);
            this.textBoxNumero.TabIndex = 18;
            this.textBoxNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImporte_KeyDown);
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImporte_KeyPress);
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(102, 58);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(212, 21);
            this.comboBoxMoneda.TabIndex = 31;
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(102, 85);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(212, 21);
            this.comboBoxPais.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fecha Apertura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tipo Cuenta:";
            // 
            // comboBoxTipoCuenta
            // 
            this.comboBoxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoCuenta.FormattingEnabled = true;
            this.comboBoxTipoCuenta.Location = new System.Drawing.Point(102, 112);
            this.comboBoxTipoCuenta.Name = "comboBoxTipoCuenta";
            this.comboBoxTipoCuenta.Size = new System.Drawing.Size(212, 21);
            this.comboBoxTipoCuenta.TabIndex = 35;
            this.comboBoxTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(102, 139);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerFecha.TabIndex = 36;
            // 
            // botomVolver
            // 
            this.botomVolver.Location = new System.Drawing.Point(15, 174);
            this.botomVolver.Name = "botomVolver";
            this.botomVolver.Size = new System.Drawing.Size(75, 23);
            this.botomVolver.TabIndex = 37;
            this.botomVolver.Text = "Volver";
            this.botomVolver.UseVisualStyleBackColor = true;
            this.botomVolver.Click += new System.EventHandler(this.botomVolver_Click);
            // 
            // botomAlta
            // 
            this.botomAlta.Location = new System.Drawing.Point(239, 174);
            this.botomAlta.Name = "botomAlta";
            this.botomAlta.Size = new System.Drawing.Size(75, 23);
            this.botomAlta.TabIndex = 39;
            this.botomAlta.Text = "Alta";
            this.botomAlta.UseVisualStyleBackColor = true;
            this.botomAlta.Click += new System.EventHandler(this.botomAlta_Click);
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Location = new System.Drawing.Point(102, 32);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(212, 20);
            this.textBoxIdUsuario.TabIndex = 40;
            this.textBoxIdUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImporte_KeyDown);
            this.textBoxIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImporte_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID Usuario:";
            // 
            // FormCuentaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 205);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIdUsuario);
            this.Controls.Add(this.botomAlta);
            this.Controls.Add(this.botomVolver);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.comboBoxTipoCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCuentaAlta";
            this.Text = "FormCuentaAlta";
            this.Load += new System.EventHandler(this.FormCuentaAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipoCuenta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button botomVolver;
        private System.Windows.Forms.Button botomAlta;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.Label label5;
    }
}