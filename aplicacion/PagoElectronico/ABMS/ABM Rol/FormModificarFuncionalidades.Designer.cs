namespace PagoElectronico.ABMS.ABM_Rol
{
    partial class FormModificarFuncionalidades
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
            this.DGFuncionalidades = new System.Windows.Forms.DataGridView();
            this.idFuncionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAgregarQuitar = new System.Windows.Forms.Button();
            this.comboBoxFuncionalidades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // DGFuncionalidades
            // 
            this.DGFuncionalidades.AllowUserToAddRows = false;
            this.DGFuncionalidades.AllowUserToDeleteRows = false;
            this.DGFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionalidad,
            this.nombre});
            this.DGFuncionalidades.Location = new System.Drawing.Point(11, 24);
            this.DGFuncionalidades.Margin = new System.Windows.Forms.Padding(2);
            this.DGFuncionalidades.Name = "DGFuncionalidades";
            this.DGFuncionalidades.ReadOnly = true;
            this.DGFuncionalidades.RowHeadersVisible = false;
            this.DGFuncionalidades.RowTemplate.Height = 16;
            this.DGFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGFuncionalidades.Size = new System.Drawing.Size(307, 210);
            this.DGFuncionalidades.TabIndex = 42;
            // 
            // idFuncionalidad
            // 
            this.idFuncionalidad.HeaderText = "ID Funcionalidad";
            this.idFuncionalidad.Name = "idFuncionalidad";
            this.idFuncionalidad.ReadOnly = true;
            this.idFuncionalidad.Width = 150;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Funcionalidades del rol";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(11, 290);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 44;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonAgregarQuitar
            // 
            this.botonAgregarQuitar.Location = new System.Drawing.Point(206, 279);
            this.botonAgregarQuitar.Name = "botonAgregarQuitar";
            this.botonAgregarQuitar.Size = new System.Drawing.Size(96, 34);
            this.botonAgregarQuitar.TabIndex = 49;
            this.botonAgregarQuitar.Text = "Agregar/Quitar Funcionalidad";
            this.botonAgregarQuitar.UseVisualStyleBackColor = true;
            this.botonAgregarQuitar.Click += new System.EventHandler(this.botonAgregarQuitar_Click);
            // 
            // comboBoxFuncionalidades
            // 
            this.comboBoxFuncionalidades.FormattingEnabled = true;
            this.comboBoxFuncionalidades.Location = new System.Drawing.Point(144, 252);
            this.comboBoxFuncionalidades.Name = "comboBoxFuncionalidades";
            this.comboBoxFuncionalidades.Size = new System.Drawing.Size(158, 21);
            this.comboBoxFuncionalidades.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Funcionalidad Disponibles";
            // 
            // FormModificarFuncionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFuncionalidades);
            this.Controls.Add(this.botonAgregarQuitar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGFuncionalidades);
            this.Name = "FormModificarFuncionalidades";
            this.Text = "FormModificarFuncionalidades";
            this.Load += new System.EventHandler(this.FormModificarFuncionalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGFuncionalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAgregarQuitar;
        private System.Windows.Forms.ComboBox comboBoxFuncionalidades;
        private System.Windows.Forms.Label label2;
    }
}