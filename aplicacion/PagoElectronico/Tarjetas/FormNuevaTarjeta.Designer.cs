namespace PagoElectronico.Tarjetas
{
    partial class FormNuevaTarjeta
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
            this.emisorTarjetaLabel = new System.Windows.Forms.Label();
            this.comboBoxEmisor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.dateTimePickerEmision = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAsociar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emisorTarjetaLabel
            // 
            this.emisorTarjetaLabel.AutoSize = true;
            this.emisorTarjetaLabel.Location = new System.Drawing.Point(6, 41);
            this.emisorTarjetaLabel.Name = "emisorTarjetaLabel";
            this.emisorTarjetaLabel.Size = new System.Drawing.Size(41, 13);
            this.emisorTarjetaLabel.TabIndex = 4;
            this.emisorTarjetaLabel.Text = "Emisor:";
            // 
            // comboBoxEmisor
            // 
            this.comboBoxEmisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmisor.FormattingEnabled = true;
            this.comboBoxEmisor.Location = new System.Drawing.Point(108, 38);
            this.comboBoxEmisor.Name = "comboBoxEmisor";
            this.comboBoxEmisor.Size = new System.Drawing.Size(208, 21);
            this.comboBoxEmisor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "FechaEmision:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Vencimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cod Seguridad:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(108, 12);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(208, 20);
            this.textBoxNumero.TabIndex = 10;
            this.textBoxNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumero_KeyDown);
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(108, 117);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(208, 20);
            this.textBoxCod.TabIndex = 11;
            // 
            // dateTimePickerEmision
            // 
            this.dateTimePickerEmision.Location = new System.Drawing.Point(108, 65);
            this.dateTimePickerEmision.Name = "dateTimePickerEmision";
            this.dateTimePickerEmision.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerEmision.TabIndex = 16;
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(108, 91);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerVencimiento.TabIndex = 17;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(12, 154);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 18;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonAsociar
            // 
            this.botonAsociar.Location = new System.Drawing.Point(238, 154);
            this.botonAsociar.Name = "botonAsociar";
            this.botonAsociar.Size = new System.Drawing.Size(75, 23);
            this.botonAsociar.TabIndex = 19;
            this.botonAsociar.Text = "Asociar";
            this.botonAsociar.UseVisualStyleBackColor = true;
            this.botonAsociar.Click += new System.EventHandler(this.botonAsociar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(119, 154);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 20;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // FormNuevaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 186);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonAsociar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.dateTimePickerVencimiento);
            this.Controls.Add(this.dateTimePickerEmision);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmisor);
            this.Controls.Add(this.emisorTarjetaLabel);
            this.Name = "FormNuevaTarjeta";
            this.Text = "Asociar Nueva Tarjeta";
            this.Load += new System.EventHandler(this.FormNuevaTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emisorTarjetaLabel;
        private System.Windows.Forms.ComboBox comboBoxEmisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmision;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimiento;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAsociar;
        private System.Windows.Forms.Button botonLimpiar;
    }
}