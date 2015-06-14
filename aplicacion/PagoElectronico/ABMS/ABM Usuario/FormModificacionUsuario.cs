using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Services;
using PagoElectronico.Dominio;

namespace PagoElectronico.ABM_Usuario
{
    public partial class FormModificacionUsuario : Form
    {
        private DataTable tablaUsers;

        public FormModificacionUsuario()
        {
            InitializeComponent();
        }

        private void FormModificacionUsuario_Load(object sender, EventArgs e)
        {
            fillRoles();
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
            DataTable dt = RolServices.getRoles();
            dt.Rows.Add(0, "Todos");
            comboBoxRol.DataSource = dt;
            comboBoxRol.DisplayMember = "nombreRol";
            comboBoxRol.ValueMember = "idRol";


        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            tablaUsers = new DataTable();
            if (textBoxUserL.Text.Equals("") && comboBoxRol.Text.Equals("")
                && dateTimePickerFechaCrea.Text.Equals("") && dateTimePickerFechaModif.Text.Equals(""))
            {
                MessageBox.Show("Complete alguno de los campos para realizar la búsqueda: Uer, Rol, Fecha Alta o Fecha Modificación");
            }
            else {
                try{
                    tablaUsers = UsuarioServices.GetUserByFiltros(textBoxUserL.Text, int.Parse(comboBoxRol.SelectedValue.ToString()),
                                dateTimePickerFechaCrea.Value, dateTimePickerFechaModif.Value); 
                    if (tablaUsers.Rows.Count == 0)
                    {
                        MessageBox.Show("El Cliente que busca no existe");

                        tablaUsers.Reset();
                        dataGridViewCliente.DataSource = tablaUsers;

                    }
                    else
                    {
                        dataGridViewCliente.DataSource = tablaUsers;
                    }
                } catch (FormatException){

                    MessageBox.Show("Se ingreso un dato con formato incorrecto");

                }
            }
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechaCrea_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
