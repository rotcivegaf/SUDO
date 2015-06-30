namespace PagoElectronico.ABMS.ABM_Cuenta
{
    partial class FormCuentaModificarAdmin
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
            this.botomVolver = new System.Windows.Forms.Button();
            this.botomAlta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botomVolver
            // 
            this.botomVolver.Location = new System.Drawing.Point(99, 128);
            this.botomVolver.Name = "botomVolver";
            this.botomVolver.Size = new System.Drawing.Size(75, 23);
            this.botomVolver.TabIndex = 38;
            this.botomVolver.Text = "Volver";
            this.botomVolver.UseVisualStyleBackColor = true;
            this.botomVolver.Click += new System.EventHandler(this.botomVolver_Click);
            // 
            // botomAlta
            // 
            this.botomAlta.Location = new System.Drawing.Point(236, 128);
            this.botomAlta.Name = "botomAlta";
            this.botomAlta.Size = new System.Drawing.Size(75, 23);
            this.botomAlta.TabIndex = 40;
            this.botomAlta.Text = "Alta";
            this.botomAlta.UseVisualStyleBackColor = true;
            this.botomAlta.Click += new System.EventHandler(this.botomAlta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tipo Cuenta:";
            // 
            // comboBoxTipoCuenta
            // 
            this.comboBoxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoCuenta.FormattingEnabled = true;
            this.comboBoxTipoCuenta.Location = new System.Drawing.Point(99, 32);
            this.comboBoxTipoCuenta.Name = "comboBoxTipoCuenta";
            this.comboBoxTipoCuenta.Size = new System.Drawing.Size(212, 21);
            this.comboBoxTipoCuenta.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Numero Cuenta:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(99, 6);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(212, 20);
            this.textBoxNumero.TabIndex = 45;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Estado Cuenta:";
            // 
            // FormCuentaModificarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTipoCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botomAlta);
            this.Controls.Add(this.botomVolver);
            this.Name = "FormCuentaModificarAdmin";
            this.Text = "FormCuentaAdmin";
            this.Load += new System.EventHandler(this.FormCuentaModificarAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botomVolver;
        private System.Windows.Forms.Button botomAlta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipoCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}