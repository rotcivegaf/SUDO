namespace PagoElectronico.Retiros
{
    partial class FormRetiro
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emisorTarjetaLabel = new System.Windows.Forms.Label();
            this.comboBoxCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNroDoc = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonRetirar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBanco = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Importe:";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(64, 71);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(208, 20);
            this.textBoxImporte.TabIndex = 17;
            this.textBoxImporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImporte_KeyDown);
            this.textBoxImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImporte_KeyPress);
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(64, 44);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(212, 21);
            this.comboBoxMoneda.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Moneda:";
            // 
            // emisorTarjetaLabel
            // 
            this.emisorTarjetaLabel.AutoSize = true;
            this.emisorTarjetaLabel.Location = new System.Drawing.Point(12, 15);
            this.emisorTarjetaLabel.Name = "emisorTarjetaLabel";
            this.emisorTarjetaLabel.Size = new System.Drawing.Size(44, 13);
            this.emisorTarjetaLabel.TabIndex = 20;
            this.emisorTarjetaLabel.Text = "Cuenta:";
            // 
            // comboBoxCuenta
            // 
            this.comboBoxCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCuenta.FormattingEnabled = true;
            this.comboBoxCuenta.Location = new System.Drawing.Point(64, 12);
            this.comboBoxCuenta.Name = "comboBoxCuenta";
            this.comboBoxCuenta.Size = new System.Drawing.Size(212, 21);
            this.comboBoxCuenta.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nro Doc:";
            // 
            // textBoxNroDoc
            // 
            this.textBoxNroDoc.Location = new System.Drawing.Point(64, 100);
            this.textBoxNroDoc.Name = "textBoxNroDoc";
            this.textBoxNroDoc.Size = new System.Drawing.Size(208, 20);
            this.textBoxNroDoc.TabIndex = 23;
            this.textBoxNroDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNroDoc_KeyDown);
            this.textBoxNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNroDoc_KeyPress);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(11, 158);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 24;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(105, 158);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 25;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonRetirar
            // 
            this.botonRetirar.Location = new System.Drawing.Point(197, 158);
            this.botonRetirar.Name = "botonRetirar";
            this.botonRetirar.Size = new System.Drawing.Size(75, 23);
            this.botonRetirar.TabIndex = 26;
            this.botonRetirar.Text = "Retirar";
            this.botonRetirar.UseVisualStyleBackColor = true;
            this.botonRetirar.Click += new System.EventHandler(this.botonRetirar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Banco:";
            // 
            // comboBoxBanco
            // 
            this.comboBoxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBanco.FormattingEnabled = true;
            this.comboBoxBanco.Location = new System.Drawing.Point(64, 126);
            this.comboBoxBanco.Name = "comboBoxBanco";
            this.comboBoxBanco.Size = new System.Drawing.Size(212, 21);
            this.comboBoxBanco.TabIndex = 28;
            // 
            // FormRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.comboBoxBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonRetirar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.textBoxNroDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCuenta);
            this.Controls.Add(this.emisorTarjetaLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.label5);
            this.Name = "FormRetiro";
            this.Text = "Retiros";
            this.Load += new System.EventHandler(this.FormRetiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label emisorTarjetaLabel;
        private System.Windows.Forms.ComboBox comboBoxCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNroDoc;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonRetirar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBanco;
    }
}