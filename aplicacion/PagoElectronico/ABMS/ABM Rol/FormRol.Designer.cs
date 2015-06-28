namespace PagoElectronico.ABMS.ABM_Rol
{
    partial class FormRol
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
            this.comboBoxIdRoles = new System.Windows.Forms.ComboBox();
            this.DGRoles = new System.Windows.Forms.DataGridView();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonModificarEstado = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonCrear = new System.Windows.Forms.Button();
            this.botonModificarNombre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonModificarFuncionalidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIdRoles
            // 
            this.comboBoxIdRoles.FormattingEnabled = true;
            this.comboBoxIdRoles.Location = new System.Drawing.Point(65, 8);
            this.comboBoxIdRoles.Name = "comboBoxIdRoles";
            this.comboBoxIdRoles.Size = new System.Drawing.Size(158, 21);
            this.comboBoxIdRoles.TabIndex = 42;
            // 
            // DGRoles
            // 
            this.DGRoles.AllowUserToAddRows = false;
            this.DGRoles.AllowUserToDeleteRows = false;
            this.DGRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRol,
            this.nombre,
            this.estado});
            this.DGRoles.Location = new System.Drawing.Point(11, 96);
            this.DGRoles.Margin = new System.Windows.Forms.Padding(2);
            this.DGRoles.Name = "DGRoles";
            this.DGRoles.ReadOnly = true;
            this.DGRoles.RowHeadersVisible = false;
            this.DGRoles.RowTemplate.Height = 16;
            this.DGRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGRoles.Size = new System.Drawing.Size(270, 195);
            this.DGRoles.TabIndex = 41;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "ID Rol";
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Width = 60;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 50;
            // 
            // botonModificarEstado
            // 
            this.botonModificarEstado.Location = new System.Drawing.Point(229, 6);
            this.botonModificarEstado.Name = "botonModificarEstado";
            this.botonModificarEstado.Size = new System.Drawing.Size(103, 23);
            this.botonModificarEstado.TabIndex = 40;
            this.botonModificarEstado.Text = "Modificar Estado";
            this.botonModificarEstado.UseVisualStyleBackColor = true;
            this.botonModificarEstado.Click += new System.EventHandler(this.botonModificarEstado_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(21, 304);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 38;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(198, 304);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(75, 23);
            this.botonCrear.TabIndex = 37;
            this.botonCrear.Text = "Crear Rol";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // botonModificarNombre
            // 
            this.botonModificarNombre.Location = new System.Drawing.Point(229, 35);
            this.botonModificarNombre.Name = "botonModificarNombre";
            this.botonModificarNombre.Size = new System.Drawing.Size(103, 23);
            this.botonModificarNombre.TabIndex = 36;
            this.botonModificarNombre.Text = "Modificar Nombre";
            this.botonModificarNombre.UseVisualStyleBackColor = true;
            this.botonModificarNombre.Click += new System.EventHandler(this.botonModificarNombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "ID Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 46;
            // 
            // botonModificarFuncionalidades
            // 
            this.botonModificarFuncionalidades.Location = new System.Drawing.Point(188, 68);
            this.botonModificarFuncionalidades.Name = "botonModificarFuncionalidades";
            this.botonModificarFuncionalidades.Size = new System.Drawing.Size(144, 23);
            this.botonModificarFuncionalidades.TabIndex = 47;
            this.botonModificarFuncionalidades.Text = "Modificar Funcionalidades";
            this.botonModificarFuncionalidades.UseVisualStyleBackColor = true;
            this.botonModificarFuncionalidades.Click += new System.EventHandler(this.botonModificarFuncionalidades_Click);
            // 
            // FormRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 337);
            this.Controls.Add(this.botonModificarFuncionalidades);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxIdRoles);
            this.Controls.Add(this.DGRoles);
            this.Controls.Add(this.botonModificarEstado);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.botonModificarNombre);
            this.Name = "FormRol";
            this.Text = "FormRol";
            this.Load += new System.EventHandler(this.FormRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdRoles;
        private System.Windows.Forms.DataGridView DGRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button botonModificarEstado;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Button botonModificarNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonModificarFuncionalidades;

    }
}