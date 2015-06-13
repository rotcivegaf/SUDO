using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Services;

namespace PagoElectronico.ABM_Usuario
{
    public partial class FormModificacionUsuario : Form
    {
        public FormModificacionUsuario()
        {
            InitializeComponent();
            fillRoles();
        }

        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormModificacionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNewUsuario_Click(object sender, EventArgs e)
        {
            FormAltaUsuario formAltaUsuario = new FormAltaUsuario();
            formAltaUsuario.ShowDialog(this);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void fillRoles()
        {
            comboBoxRol.DataSource = RolServices.getRoles();
            comboBoxRol.DisplayMember = "nombreRol";
            comboBoxRol.ValueMember = "idRol";
        }
    }
}
