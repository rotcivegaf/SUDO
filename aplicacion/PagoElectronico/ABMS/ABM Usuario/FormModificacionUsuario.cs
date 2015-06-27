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
            DateTime? fechaA;
            DateTime? fechaM;
            try
            {
                if (checkFechaC.Checked)
                {
                    fechaA = (DateTime?)null;
                }
                else
                {
                    fechaA = dateTimePickerFechaModif.Value;
                }
                if (checkFechaModf.Checked)
                {
                    fechaM = (DateTime?)null;
                }
                else
                {
                    fechaM = dateTimePickerFechaCrea.Value;
                }

                tablaUsers = UsuarioServices.GetUserByFiltros(textBoxUserL.Text, int.Parse(comboBoxRol.SelectedValue.ToString()),
                            fechaA, fechaM);
                if (tablaUsers.Rows.Count == 0)
                {
                    MessageBox.Show("El Cliente que busca no existe");

                    tablaUsers.Reset();
                    dataGridViewUsuario.DataSource = tablaUsers;

                }
                else
                {
                    dataGridViewUsuario.DataSource = tablaUsers;
                    dataGridViewUsuario.Columns["id"].Visible = false;
                    dataGridViewUsuario.Columns["fechaCreacion"].HeaderText = "Fecha de Creación";
                    dataGridViewUsuario.Columns["fechaUltimaModificacion"].HeaderText = "Fecha de Modificación";
                    dataGridViewUsuario.Columns["Usuario"].DisplayIndex = 0;
                    dataGridViewUsuario.Columns["fechaCreacion"].DisplayIndex = 1;
                    dataGridViewUsuario.Columns["fechaUltimaModificacion"].DisplayIndex = 2;
                    dataGridViewUsuario.Columns["delete"].DisplayIndex = 3;
                    dataGridViewUsuario.Columns["select"].DisplayIndex = 4;
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Se ingreso un dato con formato incorrecto");

            }
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewUsuario.Rows[e.RowIndex];
                String id = row.Cells["id"].Value.ToString();
                //Button edition
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    FormAltaUsuario formAltaUsuario = new FormAltaUsuario();
                    formAltaUsuario.Show(this);
                }
                else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    DialogResult resultado;
                    resultado = MessageBox.Show("Confirma eliminar, el usuario. user: ", "Confirmacion Eliminación Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

            }

        }

        private void groupBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechaCrea_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxUserList_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkFechaC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFechaC.Checked)
            {
                dateTimePickerFechaCrea.Enabled = false;
            }
            else
            {
                dateTimePickerFechaCrea.Enabled = true;
            }
        }

        private void checkFechaModf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFechaModf.Checked)
            {
                dateTimePickerFechaModif.Enabled = false;
            }
            else
            {
                dateTimePickerFechaModif.Enabled = true;
            }

        }
    }
}
