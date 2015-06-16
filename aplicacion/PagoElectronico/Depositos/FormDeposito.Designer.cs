namespace PagoElectronico.Depositos
{
    partial class FormDeposito
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
            this.comboBoxCuenta = new System.Windows.Forms.ComboBox();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.comboBoxTarjCred = new System.Windows.Forms.ComboBox();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.emisorTarjetaLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonDepositar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCuenta
            // 
            this.comboBoxCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCuenta.FormattingEnabled = true;
            this.comboBoxCuenta.Location = new System.Drawing.Point(76, 4);
            this.comboBoxCuenta.Name = "comboBoxCuenta";
            this.comboBoxCuenta.Size = new System.Drawing.Size(212, 21);
            this.comboBoxCuenta.TabIndex = 5;
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(76, 55);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(212, 21);
            this.comboBoxMoneda.TabIndex = 8;
            // 
            // comboBoxTarjCred
            // 
            this.comboBoxTarjCred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTarjCred.FormattingEnabled = true;
            this.comboBoxTarjCred.Location = new System.Drawing.Point(76, 82);
            this.comboBoxTarjCred.Name = "comboBoxTarjCred";
            this.comboBoxTarjCred.Size = new System.Drawing.Size(212, 21);
            this.comboBoxTarjCred.TabIndex = 10;
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(76, 31);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(208, 20);
            this.textBoxImporte.TabIndex = 12;
            this.textBoxImporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImporte_KeyDown);
            this.textBoxImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImporte_KeyPress);
            // 
            // emisorTarjetaLabel
            // 
            this.emisorTarjetaLabel.AutoSize = true;
            this.emisorTarjetaLabel.Location = new System.Drawing.Point(12, 7);
            this.emisorTarjetaLabel.Name = "emisorTarjetaLabel";
            this.emisorTarjetaLabel.Size = new System.Drawing.Size(44, 13);
            this.emisorTarjetaLabel.TabIndex = 14;
            this.emisorTarjetaLabel.Text = "Cuenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Importe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Moneda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tarj Cred:";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(15, 124);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 19;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonDepositar
            // 
            this.botonDepositar.Location = new System.Drawing.Point(209, 124);
            this.botonDepositar.Name = "botonDepositar";
            this.botonDepositar.Size = new System.Drawing.Size(75, 23);
            this.botonDepositar.TabIndex = 20;
            this.botonDepositar.Text = "Depositar";
            this.botonDepositar.UseVisualStyleBackColor = true;
            this.botonDepositar.Click += new System.EventHandler(this.botonDepositar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(113, 124);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 21;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // FormDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 162);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonDepositar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emisorTarjetaLabel);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.comboBoxTarjCred);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.comboBoxCuenta);
            this.Name = "FormDeposito";
            this.Text = "Depositos";
            this.Load += new System.EventHandler(this.FormDeposito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCuenta;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.ComboBox comboBoxTarjCred;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.Label emisorTarjetaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonDepositar;
        private System.Windows.Forms.Button botonLimpiar;
    }
}