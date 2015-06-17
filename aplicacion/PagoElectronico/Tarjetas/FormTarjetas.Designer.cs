namespace PagoElectronico.Tarjetas
{
    partial class FormTarjetas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGTarjetas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonDesasociar = new System.Windows.Forms.Button();
            this.leyendaCliId = new System.Windows.Forms.Label();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.botonAsociar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTarjetas
            // 
            this.DGTarjetas.AllowUserToAddRows = false;
            this.DGTarjetas.AllowUserToDeleteRows = false;
            this.DGTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Numero,
            this.FechaEmision,
            this.FechaVencimiento,
            this.Emisor,
            this.Estado});
            this.DGTarjetas.Location = new System.Drawing.Point(21, 70);
            this.DGTarjetas.Margin = new System.Windows.Forms.Padding(2);
            this.DGTarjetas.Name = "DGTarjetas";
            this.DGTarjetas.ReadOnly = true;
            this.DGTarjetas.RowHeadersVisible = false;
            this.DGTarjetas.RowTemplate.Height = 16;
            this.DGTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTarjetas.Size = new System.Drawing.Size(636, 235);
            this.DGTarjetas.TabIndex = 13;
            this.DGTarjetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTarjetas_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "IdTarjeta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 75;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // FechaEmision
            // 
            this.FechaEmision.HeaderText = "Fecha Emision";
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.ReadOnly = true;
            this.FechaEmision.Width = 150;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.Width = 150;
            // 
            // Emisor
            // 
            this.Emisor.HeaderText = "Emisor";
            this.Emisor.Name = "Emisor";
            this.Emisor.ReadOnly = true;
            this.Emisor.Width = 120;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(21, 323);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 14;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonDesasociar
            // 
            this.botonDesasociar.Location = new System.Drawing.Point(197, 12);
            this.botonDesasociar.Name = "botonDesasociar";
            this.botonDesasociar.Size = new System.Drawing.Size(185, 23);
            this.botonDesasociar.TabIndex = 15;
            this.botonDesasociar.Text = "Desasociar Tarjeta Seleccionada";
            this.botonDesasociar.UseVisualStyleBackColor = true;
            this.botonDesasociar.Click += new System.EventHandler(this.botonDesasociar_Click);
            // 
            // leyendaCliId
            // 
            this.leyendaCliId.AutoSize = true;
            this.leyendaCliId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leyendaCliId.Location = new System.Drawing.Point(18, 52);
            this.leyendaCliId.Name = "leyendaCliId";
            this.leyendaCliId.Size = new System.Drawing.Size(66, 16);
            this.leyendaCliId.TabIndex = 16;
            this.leyendaCliId.Text = "Tarjetas";
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(91, 45);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(69, 23);
            this.botonActualizar.TabIndex = 17;
            this.botonActualizar.Text = "Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonAsociar
            // 
            this.botonAsociar.Location = new System.Drawing.Point(21, 12);
            this.botonAsociar.Name = "botonAsociar";
            this.botonAsociar.Size = new System.Drawing.Size(159, 23);
            this.botonAsociar.TabIndex = 18;
            this.botonAsociar.Text = "Asociar Nueva Tarjeta";
            this.botonAsociar.UseVisualStyleBackColor = true;
            this.botonAsociar.Click += new System.EventHandler(this.botonAsociar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seleccione el IdTarjeta a la cual quiere codificar o desasociar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Seleccione solo un IdTarjeta";
            // 
            // FormTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonAsociar);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.leyendaCliId);
            this.Controls.Add(this.botonDesasociar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.DGTarjetas);
            this.Name = "FormTarjetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTarjetas";
            this.Load += new System.EventHandler(this.FormTarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTarjetas;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonDesasociar;
        private System.Windows.Forms.Label leyendaCliId;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.Button botonAsociar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}