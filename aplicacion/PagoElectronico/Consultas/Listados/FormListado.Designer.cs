namespace PagoElectronico.Listados
{
    partial class FormListado
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botonConsultar1 = new System.Windows.Forms.Button();
            this.dGV4 = new System.Windows.Forms.DataGridView();
            this.idPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV3 = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV2 = new System.Windows.Forms.DataGridView();
            this.idCliente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV5 = new System.Windows.Forms.DataGridView();
            this.tipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFacturado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.idCliente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonConsultar2 = new System.Windows.Forms.Button();
            this.botonConsultar3 = new System.Windows.Forms.Button();
            this.botonConsultar4 = new System.Windows.Forms.Button();
            this.botonConsultar5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(172, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trimestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonConsultar1
            // 
            this.botonConsultar1.Location = new System.Drawing.Point(227, 183);
            this.botonConsultar1.Name = "botonConsultar1";
            this.botonConsultar1.Size = new System.Drawing.Size(75, 23);
            this.botonConsultar1.TabIndex = 7;
            this.botonConsultar1.Text = "Consultar";
            this.botonConsultar1.UseVisualStyleBackColor = true;
            this.botonConsultar1.Click += new System.EventHandler(this.botonConsultar1_Click);
            // 
            // dGV4
            // 
            this.dGV4.AllowUserToAddRows = false;
            this.dGV4.AllowUserToDeleteRows = false;
            this.dGV4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPais,
            this.Pais});
            this.dGV4.Location = new System.Drawing.Point(306, 69);
            this.dGV4.Margin = new System.Windows.Forms.Padding(2);
            this.dGV4.Name = "dGV4";
            this.dGV4.ReadOnly = true;
            this.dGV4.RowHeadersVisible = false;
            this.dGV4.RowTemplate.Height = 16;
            this.dGV4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV4.Size = new System.Drawing.Size(196, 109);
            this.dGV4.TabIndex = 24;
            // 
            // idPais
            // 
            this.idPais.HeaderText = "Nombre Pais";
            this.idPais.Name = "idPais";
            this.idPais.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Cantidad";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            this.Pais.Width = 90;
            // 
            // dGV3
            // 
            this.dGV3.AllowUserToAddRows = false;
            this.dGV3.AllowUserToDeleteRows = false;
            this.dGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.userName,
            this.cantidad});
            this.dGV3.Location = new System.Drawing.Point(11, 382);
            this.dGV3.Margin = new System.Windows.Forms.Padding(2);
            this.dGV3.Name = "dGV3";
            this.dGV3.ReadOnly = true;
            this.dGV3.RowHeadersVisible = false;
            this.dGV3.RowTemplate.Height = 16;
            this.dGV3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV3.Size = new System.Drawing.Size(281, 109);
            this.dGV3.TabIndex = 25;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "ID Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.HeaderText = "User Name";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cant";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 75;
            // 
            // dGV2
            // 
            this.dGV2.AllowUserToAddRows = false;
            this.dGV2.AllowUserToDeleteRows = false;
            this.dGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente2,
            this.userName2,
            this.cantidad2});
            this.dGV2.Location = new System.Drawing.Point(11, 230);
            this.dGV2.Margin = new System.Windows.Forms.Padding(2);
            this.dGV2.Name = "dGV2";
            this.dGV2.ReadOnly = true;
            this.dGV2.RowHeadersVisible = false;
            this.dGV2.RowTemplate.Height = 16;
            this.dGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV2.Size = new System.Drawing.Size(291, 109);
            this.dGV2.TabIndex = 26;
            // 
            // idCliente2
            // 
            this.idCliente2.HeaderText = "ID Cliente";
            this.idCliente2.Name = "idCliente2";
            this.idCliente2.ReadOnly = true;
            // 
            // userName2
            // 
            this.userName2.HeaderText = "User Name";
            this.userName2.Name = "userName2";
            this.userName2.ReadOnly = true;
            // 
            // cantidad2
            // 
            this.cantidad2.HeaderText = "Cantidad";
            this.cantidad2.Name = "cantidad2";
            this.cantidad2.ReadOnly = true;
            this.cantidad2.Width = 80;
            // 
            // dGV5
            // 
            this.dGV5.AllowUserToAddRows = false;
            this.dGV5.AllowUserToDeleteRows = false;
            this.dGV5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoCuenta,
            this.totalFacturado});
            this.dGV5.Location = new System.Drawing.Point(306, 230);
            this.dGV5.Margin = new System.Windows.Forms.Padding(2);
            this.dGV5.Name = "dGV5";
            this.dGV5.ReadOnly = true;
            this.dGV5.RowHeadersVisible = false;
            this.dGV5.RowTemplate.Height = 16;
            this.dGV5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV5.Size = new System.Drawing.Size(259, 109);
            this.dGV5.TabIndex = 27;
            // 
            // tipoCuenta
            // 
            this.tipoCuenta.HeaderText = "Tipo Cuenta";
            this.tipoCuenta.Name = "tipoCuenta";
            this.tipoCuenta.ReadOnly = true;
            // 
            // totalFacturado
            // 
            this.totalFacturado.HeaderText = "Total Facturado";
            this.totalFacturado.Name = "totalFacturado";
            this.totalFacturado.ReadOnly = true;
            this.totalFacturado.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "TOP 5 paises con mayor cantidad de movimientos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total Facturado por los distintos tipos de cuentas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "TOP 5 clientes con mayor cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "de transacciones entre cuentas propias ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "TOP 5 Clientes con cuentas que";
            // 
            // dGV1
            // 
            this.dGV1.AllowUserToAddRows = false;
            this.dGV1.AllowUserToDeleteRows = false;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente1,
            this.userName1,
            this.cant1});
            this.dGV1.Location = new System.Drawing.Point(11, 69);
            this.dGV1.Margin = new System.Windows.Forms.Padding(2);
            this.dGV1.Name = "dGV1";
            this.dGV1.ReadOnly = true;
            this.dGV1.RowHeadersVisible = false;
            this.dGV1.RowTemplate.Height = 16;
            this.dGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV1.Size = new System.Drawing.Size(291, 109);
            this.dGV1.TabIndex = 33;
            // 
            // idCliente1
            // 
            this.idCliente1.HeaderText = "ID Cliente";
            this.idCliente1.Name = "idCliente1";
            this.idCliente1.ReadOnly = true;
            // 
            // userName1
            // 
            this.userName1.HeaderText = "User Name";
            this.userName1.Name = "userName1";
            this.userName1.ReadOnly = true;
            // 
            // cant1
            // 
            this.cant1.HeaderText = "Cantidad";
            this.cant1.Name = "cant1";
            this.cant1.ReadOnly = true;
            this.cant1.Width = 80;
            // 
            // botonConsultar2
            // 
            this.botonConsultar2.Location = new System.Drawing.Point(227, 344);
            this.botonConsultar2.Name = "botonConsultar2";
            this.botonConsultar2.Size = new System.Drawing.Size(75, 23);
            this.botonConsultar2.TabIndex = 34;
            this.botonConsultar2.Text = "Consultar";
            this.botonConsultar2.UseVisualStyleBackColor = true;
            this.botonConsultar2.Click += new System.EventHandler(this.botonConsultar2_Click);
            // 
            // botonConsultar3
            // 
            this.botonConsultar3.Location = new System.Drawing.Point(218, 496);
            this.botonConsultar3.Name = "botonConsultar3";
            this.botonConsultar3.Size = new System.Drawing.Size(75, 23);
            this.botonConsultar3.TabIndex = 35;
            this.botonConsultar3.Text = "Consultar";
            this.botonConsultar3.UseVisualStyleBackColor = true;
            this.botonConsultar3.Click += new System.EventHandler(this.botonConsultar3_Click);
            // 
            // botonConsultar4
            // 
            this.botonConsultar4.Location = new System.Drawing.Point(427, 183);
            this.botonConsultar4.Name = "botonConsultar4";
            this.botonConsultar4.Size = new System.Drawing.Size(75, 23);
            this.botonConsultar4.TabIndex = 36;
            this.botonConsultar4.Text = "Consultar";
            this.botonConsultar4.UseVisualStyleBackColor = true;
            this.botonConsultar4.Click += new System.EventHandler(this.botonConsultar4_Click);
            // 
            // botonConsultar5
            // 
            this.botonConsultar5.Location = new System.Drawing.Point(490, 344);
            this.botonConsultar5.Name = "botonConsultar5";
            this.botonConsultar5.Size = new System.Drawing.Size(75, 23);
            this.botonConsultar5.TabIndex = 37;
            this.botonConsultar5.Text = "Consultar";
            this.botonConsultar5.UseVisualStyleBackColor = true;
            this.botonConsultar5.Click += new System.EventHandler(this.botonConsultar5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "TOP 5 clientes con mayor cant de comisiones facturadas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "fueron inhabilitadas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 40;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 544);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.botonConsultar5);
            this.Controls.Add(this.botonConsultar4);
            this.Controls.Add(this.botonConsultar3);
            this.Controls.Add(this.botonConsultar2);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dGV5);
            this.Controls.Add(this.dGV2);
            this.Controls.Add(this.dGV3);
            this.Controls.Add(this.dGV4);
            this.Controls.Add(this.botonConsultar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados";
            this.Load += new System.EventHandler(this.FormListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonConsultar1;
        private System.Windows.Forms.DataGridView dGV4;
        private System.Windows.Forms.DataGridView dGV3;
        private System.Windows.Forms.DataGridView dGV2;
        private System.Windows.Forms.DataGridView dGV5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFacturado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Button botonConsultar2;
        private System.Windows.Forms.Button botonConsultar3;
        private System.Windows.Forms.Button botonConsultar4;
        private System.Windows.Forms.Button botonConsultar5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant1;
    }
}