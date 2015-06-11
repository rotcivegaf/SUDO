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
            this.DGTarjetas = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.leyendaCliId = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTarjetas
            // 
            this.DGTarjetas.AllowUserToAddRows = false;
            this.DGTarjetas.AllowUserToDeleteRows = false;
            this.DGTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.FechaEmision,
            this.FechaVencimiento,
            this.Emisor,
            this.Estado});
            this.DGTarjetas.Location = new System.Drawing.Point(11, 70);
            this.DGTarjetas.Margin = new System.Windows.Forms.Padding(2);
            this.DGTarjetas.Name = "DGTarjetas";
            this.DGTarjetas.ReadOnly = true;
            this.DGTarjetas.RowHeadersVisible = false;
            this.DGTarjetas.RowTemplate.Height = 16;
            this.DGTarjetas.Size = new System.Drawing.Size(628, 236);
            this.DGTarjetas.TabIndex = 13;
            this.DGTarjetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTarjetas_CellContentClick);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Desasociar Tarjeta Seleccionada";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // leyendaCliId
            // 
            this.leyendaCliId.AutoSize = true;
            this.leyendaCliId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leyendaCliId.Location = new System.Drawing.Point(8, 52);
            this.leyendaCliId.Name = "leyendaCliId";
            this.leyendaCliId.Size = new System.Drawing.Size(66, 16);
            this.leyendaCliId.TabIndex = 16;
            this.leyendaCliId.Text = "Tarjetas";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(80, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Asociar Nueva Tarjeta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.leyendaCliId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGTarjetas);
            this.Name = "FormTarjetas";
            this.Text = "FormTarjetas";
            this.Load += new System.EventHandler(this.FormTarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTarjetas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label leyendaCliId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}