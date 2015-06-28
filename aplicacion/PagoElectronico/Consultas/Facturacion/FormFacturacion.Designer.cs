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
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(12, 233);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 20;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonFacturar
            // 
            this.botonFacturar.Location = new System.Drawing.Point(174, 233);
            this.botonFacturar.Name = "botonFacturar";
            this.botonFacturar.Size = new System.Drawing.Size(75, 23);
            this.botonFacturar.TabIndex = 21;
            this.botonFacturar.Text = "Facturar";
            this.botonFacturar.UseVisualStyleBackColor = true;
            this.botonFacturar.Click += new System.EventHandler(this.botonFacturar_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(93, 233);
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
            this.descripcion,
            this.costo,
            this.importe,
            this.moneda,
            this.cuentaOrigen,
            this.cuentaDestino});
            this.DGItems.Location = new System.Drawing.Point(11, 37);
            this.DGItems.Margin = new System.Windows.Forms.Padding(2);
            this.DGItems.Name = "DGItems";
            this.DGItems.ReadOnly = true;
            this.DGItems.RowHeadersVisible = false;
            this.DGItems.RowTemplate.Height = 16;
            this.DGItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGItems.Size = new System.Drawing.Size(603, 182);
            this.DGItems.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Items a Facturar";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // moneda
            // 
            this.moneda.HeaderText = "Moneda";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            // 
            // cuentaOrigen
            // 
            this.cuentaOrigen.HeaderText = "Cuenta Origen";
            this.cuentaOrigen.Name = "cuentaOrigen";
            this.cuentaOrigen.ReadOnly = true;
            // 
            // cuentaDestino
            // 
            this.cuentaDestino.HeaderText = "CuentaDestino";
            this.cuentaDestino.Name = "cuentaDestino";
            this.cuentaDestino.ReadOnly = true;
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGItems);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.botonFacturar);
            this.Controls.Add(this.botonCancelar);
            this.Name = "FormFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.FormFacturacion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonFacturar;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.DataGridView DGItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDestino;
    }
}