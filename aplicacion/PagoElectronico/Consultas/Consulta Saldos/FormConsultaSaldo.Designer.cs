namespace PagoElectronico.Consulta_Saldos
{
    partial class FormConsultaSaldo
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DGRetiros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGDepositos = new System.Windows.Forms.DataGridView();
            this.Deposito_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito_Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia_Cuenta_Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia_Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGTransferencias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGRetiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTransferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "U$S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "10 ultimas transferencias de fondos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "5 ultimos retiros";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "5 ultimos depositos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DGRetiros
            // 
            this.DGRetiros.AllowUserToAddRows = false;
            this.DGRetiros.AllowUserToDeleteRows = false;
            this.DGRetiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRetiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DGRetiros.Location = new System.Drawing.Point(15, 210);
            this.DGRetiros.Margin = new System.Windows.Forms.Padding(2);
            this.DGRetiros.Name = "DGRetiros";
            this.DGRetiros.ReadOnly = true;
            this.DGRetiros.RowHeadersVisible = false;
            this.DGRetiros.RowTemplate.Height = 16;
            this.DGRetiros.Size = new System.Drawing.Size(439, 115);
            this.DGRetiros.TabIndex = 7;
            this.DGRetiros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRetiros_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cheque";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DGDepositos
            // 
            this.DGDepositos.AllowUserToAddRows = false;
            this.DGDepositos.AllowUserToDeleteRows = false;
            this.DGDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDepositos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deposito_Codigo,
            this.Deposito_Fecha,
            this.Deposito_Importe,
            this.Deposito_Tarjeta});
            this.DGDepositos.Location = new System.Drawing.Point(15, 78);
            this.DGDepositos.Margin = new System.Windows.Forms.Padding(2);
            this.DGDepositos.Name = "DGDepositos";
            this.DGDepositos.ReadOnly = true;
            this.DGDepositos.RowHeadersVisible = false;
            this.DGDepositos.RowTemplate.Height = 16;
            this.DGDepositos.Size = new System.Drawing.Size(451, 115);
            this.DGDepositos.TabIndex = 12;
            this.DGDepositos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDepositos_CellContentClick);
            // 
            // Deposito_Codigo
            // 
            this.Deposito_Codigo.HeaderText = "Codigo";
            this.Deposito_Codigo.Name = "Deposito_Codigo";
            this.Deposito_Codigo.ReadOnly = true;
            // 
            // Deposito_Fecha
            // 
            this.Deposito_Fecha.HeaderText = "Fecha";
            this.Deposito_Fecha.Name = "Deposito_Fecha";
            this.Deposito_Fecha.ReadOnly = true;
            this.Deposito_Fecha.Width = 150;
            // 
            // Deposito_Importe
            // 
            this.Deposito_Importe.HeaderText = "Importe";
            this.Deposito_Importe.Name = "Deposito_Importe";
            this.Deposito_Importe.ReadOnly = true;
            this.Deposito_Importe.Width = 75;
            // 
            // Deposito_Tarjeta
            // 
            this.Deposito_Tarjeta.HeaderText = "Tarjeta Ult 4 Dig";
            this.Deposito_Tarjeta.Name = "Deposito_Tarjeta";
            this.Deposito_Tarjeta.ReadOnly = true;
            this.Deposito_Tarjeta.Width = 120;
            // 
            // Transferencia_Cuenta_Destino
            // 
            this.Transferencia_Cuenta_Destino.HeaderText = "Cuenta Destino";
            this.Transferencia_Cuenta_Destino.Name = "Transferencia_Cuenta_Destino";
            this.Transferencia_Cuenta_Destino.ReadOnly = true;
            this.Transferencia_Cuenta_Destino.Width = 120;
            // 
            // Transferencia_Costo
            // 
            this.Transferencia_Costo.HeaderText = "Costo";
            this.Transferencia_Costo.Name = "Transferencia_Costo";
            this.Transferencia_Costo.ReadOnly = true;
            this.Transferencia_Costo.Width = 75;
            // 
            // Transferencia_Importe
            // 
            this.Transferencia_Importe.HeaderText = "Importe";
            this.Transferencia_Importe.Name = "Transferencia_Importe";
            this.Transferencia_Importe.ReadOnly = true;
            this.Transferencia_Importe.Width = 75;
            // 
            // Transferencia_Fecha
            // 
            this.Transferencia_Fecha.HeaderText = "Fecha";
            this.Transferencia_Fecha.Name = "Transferencia_Fecha";
            this.Transferencia_Fecha.ReadOnly = true;
            this.Transferencia_Fecha.Width = 150;
            // 
            // Transferencia_Codigo
            // 
            this.Transferencia_Codigo.HeaderText = "Codigo";
            this.Transferencia_Codigo.Name = "Transferencia_Codigo";
            this.Transferencia_Codigo.ReadOnly = true;
            // 
            // DGTransferencias
            // 
            this.DGTransferencias.AllowUserToAddRows = false;
            this.DGTransferencias.AllowUserToDeleteRows = false;
            this.DGTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTransferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transferencia_Codigo,
            this.Transferencia_Fecha,
            this.Transferencia_Importe,
            this.Transferencia_Costo,
            this.Transferencia_Cuenta_Destino});
            this.DGTransferencias.Location = new System.Drawing.Point(15, 342);
            this.DGTransferencias.Margin = new System.Windows.Forms.Padding(2);
            this.DGTransferencias.Name = "DGTransferencias";
            this.DGTransferencias.ReadOnly = true;
            this.DGTransferencias.RowHeadersVisible = false;
            this.DGTransferencias.RowTemplate.Height = 16;
            this.DGTransferencias.Size = new System.Drawing.Size(528, 209);
            this.DGTransferencias.TabIndex = 13;
            this.DGTransferencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTransferencias_CellContentClick);
            // 
            // FormConsultaSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 558);
            this.Controls.Add(this.DGTransferencias);
            this.Controls.Add(this.DGRetiros);
            this.Controls.Add(this.DGDepositos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de saldos";
            this.Load += new System.EventHandler(this.FormConsultaSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRetiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTransferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGRetiros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView DGDepositos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito_Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito_Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Cuenta_Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Codigo;
        private System.Windows.Forms.DataGridView DGTransferencias;
    }
}