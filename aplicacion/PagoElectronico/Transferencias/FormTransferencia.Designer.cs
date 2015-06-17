namespace PagoElectronico.Transferencias
{
    partial class FormTransferencia
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
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonTransferir = new System.Windows.Forms.Button();
            this.emisorTarjetaLabel = new System.Windows.Forms.Label();
            this.comboBoxCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.textBoxCuentaDest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(20, 131);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 20;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(151, 131);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 22;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonTransferir
            // 
            this.botonTransferir.Location = new System.Drawing.Point(267, 131);
            this.botonTransferir.Name = "botonTransferir";
            this.botonTransferir.Size = new System.Drawing.Size(75, 23);
            this.botonTransferir.TabIndex = 23;
            this.botonTransferir.Text = "Transferir";
            this.botonTransferir.UseVisualStyleBackColor = true;
            this.botonTransferir.Click += new System.EventHandler(this.botonTransferir_Click);
            // 
            // emisorTarjetaLabel
            // 
            this.emisorTarjetaLabel.AutoSize = true;
            this.emisorTarjetaLabel.Location = new System.Drawing.Point(12, 9);
            this.emisorTarjetaLabel.Name = "emisorTarjetaLabel";
            this.emisorTarjetaLabel.Size = new System.Drawing.Size(78, 13);
            this.emisorTarjetaLabel.TabIndex = 24;
            this.emisorTarjetaLabel.Text = "Cuenta Origen:";
            // 
            // comboBoxCuentaOrigen
            // 
            this.comboBoxCuentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCuentaOrigen.FormattingEnabled = true;
            this.comboBoxCuentaOrigen.Location = new System.Drawing.Point(104, 6);
            this.comboBoxCuentaOrigen.Name = "comboBoxCuentaOrigen";
            this.comboBoxCuentaOrigen.Size = new System.Drawing.Size(212, 21);
            this.comboBoxCuentaOrigen.TabIndex = 25;
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(104, 33);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(212, 20);
            this.textBoxImporte.TabIndex = 26;
            this.textBoxImporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImporte_KeyDown);
            this.textBoxImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImporte_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Importe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cuenta Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Moneda:";
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(104, 59);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(212, 21);
            this.comboBoxMoneda.TabIndex = 30;
            // 
            // textBoxCuentaDest
            // 
            this.textBoxCuentaDest.Location = new System.Drawing.Point(104, 89);
            this.textBoxCuentaDest.Name = "textBoxCuentaDest";
            this.textBoxCuentaDest.Size = new System.Drawing.Size(212, 20);
            this.textBoxCuentaDest.TabIndex = 32;
            this.textBoxCuentaDest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCuentaDest_KeyDown);
            this.textBoxCuentaDest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCuentaDest_KeyPress);
            // 
            // FormTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 162);
            this.Controls.Add(this.textBoxCuentaDest);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.comboBoxCuentaOrigen);
            this.Controls.Add(this.emisorTarjetaLabel);
            this.Controls.Add(this.botonTransferir);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCancelar);
            this.Name = "FormTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencias";
            this.Load += new System.EventHandler(this.FormTransferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonTransferir;
        private System.Windows.Forms.Label emisorTarjetaLabel;
        private System.Windows.Forms.ComboBox comboBoxCuentaOrigen;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.TextBox textBoxCuentaDest;
    }
}