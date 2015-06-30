namespace PagoElectronico.Facturacion
{
    partial class FormFacturacion
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
            this.botonFacturar = new System.Windows.Forms.Button();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.DGItems = new System.Windows.Forms.DataGridView();
            this.idTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGFactCuentas = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idFactCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGFactCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(11, 449);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 20;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonFacturar
            // 
            this.botonFacturar.Location = new System.Drawing.Point(531, 449);
            this.botonFacturar.Name = "botonFacturar";
            this.botonFacturar.Size = new System.Drawing.Size(85, 23);
            this.botonFacturar.TabIndex = 21;
            this.botonFacturar.Text = "Facturar";
            this.botonFacturar.UseVisualStyleBackColor = true;
            this.botonFacturar.Click += new System.EventHandler(this.botonFacturar_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(438, 449);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(75, 23);
            this.botonActualizar.TabIndex = 22;
            this.botonActualizar.Text = "Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // DGItems
            // 
            this.DGItems.AllowUserToAddRows = false;
            this.DGItems.AllowUserToDeleteRows = false;
            this.DGItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransferencia,
            this.cuentaOrigen,
            this.cuentaDestino,
            this.fechaTrans,
            this.costo,
            this.importe,
            this.moneda});
            this.DGItems.Location = new System.Drawing.Point(11, 44);
            this.DGItems.Margin = new System.Windows.Forms.Padding(2);
            this.DGItems.Name = "DGItems";
            this.DGItems.ReadOnly = true;
            this.DGItems.RowHeadersVisible = false;
            this.DGItems.RowTemplate.Height = 16;
            this.DGItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGItems.Size = new System.Drawing.Size(605, 182);
            this.DGItems.TabIndex = 23;
            // 
            // idTransferencia
            // 
            this.idTransferencia.HeaderText = "Column1";
            this.idTransferencia.Name = "idTransferencia";
            this.idTransferencia.ReadOnly = true;
            this.idTransferencia.Visible = false;
            // 
            // cuentaOrigen
            // 
            this.cuentaOrigen.HeaderText = "Cuenta Origen";
            this.cuentaOrigen.Name = "cuentaOrigen";
            this.cuentaOrigen.ReadOnly = true;
            this.cuentaOrigen.Width = 120;
            // 
            // cuentaDestino
            // 
            this.cuentaDestino.HeaderText = "CuentaDestino";
            this.cuentaDestino.Name = "cuentaDestino";
            this.cuentaDestino.ReadOnly = true;
            this.cuentaDestino.Width = 120;
            // 
            // fechaTrans
            // 
            this.fechaTrans.HeaderText = "Fecha";
            this.fechaTrans.Name = "fechaTrans";
            this.fechaTrans.ReadOnly = true;
            this.fechaTrans.Width = 120;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Width = 75;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.Width = 75;
            // 
            // moneda
            // 
            this.moneda.HeaderText = "Moneda";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            this.moneda.Width = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Transferencias a Facturar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cambios de Cuentas a Facturar";
            // 
            // DGFactCuentas
            // 
            this.DGFactCuentas.AllowUserToAddRows = false;
            this.DGFactCuentas.AllowUserToDeleteRows = false;
            this.DGFactCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFactCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactCuenta,
            this.idCuenta,
            this.importeCuentas,
            this.fecha,
            this.descripcionCuentas,
            this.monedaCuentas});
            this.DGFactCuentas.Location = new System.Drawing.Point(11, 252);
            this.DGFactCuentas.Margin = new System.Windows.Forms.Padding(2);
            this.DGFactCuentas.Name = "DGFactCuentas";
            this.DGFactCuentas.ReadOnly = true;
            this.DGFactCuentas.RowHeadersVisible = false;
            this.DGFactCuentas.RowTemplate.Height = 16;
            this.DGFactCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGFactCuentas.Size = new System.Drawing.Size(605, 182);
            this.DGFactCuentas.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cuenta";
            // 
            // idFactCuenta
            // 
            this.idFactCuenta.HeaderText = "Column1";
            this.idFactCuenta.Name = "idFactCuenta";
            this.idFactCuenta.ReadOnly = true;
            this.idFactCuenta.Visible = false;
            // 
            // idCuenta
            // 
            this.idCuenta.HeaderText = "Numero Cuenta";
            this.idCuenta.Name = "idCuenta";
            this.idCuenta.ReadOnly = true;
            this.idCuenta.Width = 120;
            // 
            // importeCuentas
            // 
            this.importeCuentas.HeaderText = "Importe";
            this.importeCuentas.Name = "importeCuentas";
            this.importeCuentas.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 120;
            // 
            // descripcionCuentas
            // 
            this.descripcionCuentas.HeaderText = "Descripcion";
            this.descripcionCuentas.Name = "descripcionCuentas";
            this.descripcionCuentas.ReadOnly = true;
            // 
            // monedaCuentas
            // 
            this.monedaCuentas.HeaderText = "Moneda";
            this.monedaCuentas.Name = "monedaCuentas";
            this.monedaCuentas.ReadOnly = true;
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DGFactCuentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGItems);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.botonFacturar);
            this.Controls.Add(this.botonCancelar);
            this.Name = "FormFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.FormFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGFactCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonFacturar;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.DataGridView DGItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGFactCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaCuentas;
    }
}