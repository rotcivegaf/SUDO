namespace PagoElectronico.ABM_Cliente
{
    partial class FormModificacionCliente
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
            this.labelNameListado = new System.Windows.Forms.Label();
            this.textBoxClienteListado = new System.Windows.Forms.TextBox();
            this.buttonLimpiarC = new System.Windows.Forms.Button();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxNroIdentif = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelNroIdentif = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.groupBoxClienteList = new System.Windows.Forms.GroupBox();
            this.buttonNewCliente = new System.Windows.Forms.Button();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltros.SuspendLayout();
            this.groupBoxClienteList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameListado
            // 
            this.labelNameListado.AutoSize = true;
            this.labelNameListado.Location = new System.Drawing.Point(34, 27);
            this.labelNameListado.Name = "labelNameListado";
            this.labelNameListado.Size = new System.Drawing.Size(44, 13);
            this.labelNameListado.TabIndex = 7;
            this.labelNameListado.Text = "Nombre";
            this.labelNameListado.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxClienteListado
            // 
            this.textBoxClienteListado.Location = new System.Drawing.Point(116, 24);
            this.textBoxClienteListado.Name = "textBoxClienteListado";
            this.textBoxClienteListado.Size = new System.Drawing.Size(121, 20);
            this.textBoxClienteListado.TabIndex = 9;
            this.textBoxClienteListado.TextChanged += new System.EventHandler(this.textBoxClienteListado_TextChanged);
            // 
            // buttonLimpiarC
            // 
            this.buttonLimpiarC.Location = new System.Drawing.Point(37, 112);
            this.buttonLimpiarC.Name = "buttonLimpiarC";
            this.buttonLimpiarC.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarC.TabIndex = 10;
            this.buttonLimpiarC.Text = "Limpiar";
            this.buttonLimpiarC.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(143, 112);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarCliente.TabIndex = 11;
            this.buttonBuscarCliente.Text = "Buscar";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.textBoxMail);
            this.groupBoxFiltros.Controls.Add(this.textBoxNroIdentif);
            this.groupBoxFiltros.Controls.Add(this.textBoxApellido);
            this.groupBoxFiltros.Controls.Add(this.buttonBuscarCliente);
            this.groupBoxFiltros.Controls.Add(this.buttonLimpiarC);
            this.groupBoxFiltros.Controls.Add(this.labelNroIdentif);
            this.groupBoxFiltros.Controls.Add(this.labelMail);
            this.groupBoxFiltros.Controls.Add(this.labelApellido);
            this.groupBoxFiltros.Controls.Add(this.labelNameListado);
            this.groupBoxFiltros.Controls.Add(this.textBoxClienteListado);
            this.groupBoxFiltros.Location = new System.Drawing.Point(36, 29);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(632, 141);
            this.groupBoxFiltros.TabIndex = 12;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros de Búsqueda";
            this.groupBoxFiltros.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(411, 59);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(121, 20);
            this.textBoxMail.TabIndex = 18;
            // 
            // textBoxNroIdentif
            // 
            this.textBoxNroIdentif.Location = new System.Drawing.Point(411, 24);
            this.textBoxNroIdentif.Name = "textBoxNroIdentif";
            this.textBoxNroIdentif.Size = new System.Drawing.Size(121, 20);
            this.textBoxNroIdentif.TabIndex = 17;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(116, 59);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(121, 20);
            this.textBoxApellido.TabIndex = 16;
            // 
            // labelNroIdentif
            // 
            this.labelNroIdentif.AutoSize = true;
            this.labelNroIdentif.Location = new System.Drawing.Point(285, 27);
            this.labelNroIdentif.Name = "labelNroIdentif";
            this.labelNroIdentif.Size = new System.Drawing.Size(93, 13);
            this.labelNroIdentif.TabIndex = 13;
            this.labelNroIdentif.Text = "Nro. Identificacion";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(285, 62);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 12;
            this.labelMail.Text = "Mail";
            this.labelMail.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(34, 62);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 11;
            this.labelApellido.Text = "Apellido";
            // 
            // groupBoxClienteList
            // 
            this.groupBoxClienteList.AutoSize = true;
            this.groupBoxClienteList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxClienteList.Controls.Add(this.buttonNewCliente);
            this.groupBoxClienteList.Controls.Add(this.dataGridViewCliente);
            this.groupBoxClienteList.Controls.Add(this.groupBoxFiltros);
            this.groupBoxClienteList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClienteList.Name = "groupBoxClienteList";
            this.groupBoxClienteList.Size = new System.Drawing.Size(708, 471);
            this.groupBoxClienteList.TabIndex = 0;
            this.groupBoxClienteList.TabStop = false;
            this.groupBoxClienteList.Text = "Listado Modificacion Cliente";
            this.groupBoxClienteList.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonNewCliente
            // 
            this.buttonNewCliente.Location = new System.Drawing.Point(593, 429);
            this.buttonNewCliente.Name = "buttonNewCliente";
            this.buttonNewCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonNewCliente.TabIndex = 14;
            this.buttonNewCliente.Text = "Nuevo";
            this.buttonNewCliente.UseVisualStyleBackColor = true;
            this.buttonNewCliente.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(36, 186);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.Size = new System.Drawing.Size(632, 228);
            this.dataGridViewCliente.TabIndex = 13;
            // 
            // FormModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(724, 470);
            this.Controls.Add(this.groupBoxClienteList);
            this.Name = "FormModificacionCliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.FormAltaCliente_Load);
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.groupBoxClienteList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameListado;
        private System.Windows.Forms.TextBox textBoxClienteListado;
        private System.Windows.Forms.Button buttonLimpiarC;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.GroupBox groupBoxClienteList;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNroIdentif;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button buttonNewCliente;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNroIdentif;
        private System.Windows.Forms.TextBox textBoxMail;


    }
}