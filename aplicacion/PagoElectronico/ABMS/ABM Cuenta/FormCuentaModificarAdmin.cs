using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using PagoElectronico.Login;
using PagoElectronico.Utils;


namespace PagoElectronico.ABMS.ABM_Cuenta
{
    public partial class FormCuentaModificarAdmin : Form
    {
        public FormCuentaModificarAdmin()
        {
            InitializeComponent();
            llenarCampos();
        }

        private void botomVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void botomAlta_Click(object sender, EventArgs e)
        {
            FormCuentaAlta formCuentaAlta = new FormCuentaAlta();
            formCuentaAlta.Show(this);
            this.Hide();
        }

        private void resetearForm()
        {
            comboBox1.ResetText();
            comboBoxTipoCuenta.ResetText();
            textBoxNumero.Text = "";
        }

        private void FormCuentaModificarAdmin_Load(object sender, EventArgs e)
        {

        }

        private void llenarCampos()
        {
            /*lleno el campo tipo cuenta*/
            comboBoxTipoCuenta.Items.Add("");
            List<SqlParameter> parametrosTipo = new List<SqlParameter>();
            SqlDataReader readerTipo = DAO.ConexionDB.ejecReaderProc("SUDO.GetTiposCuenta", parametrosTipo);
            for (; readerTipo.Read(); comboBoxTipoCuenta.Items.Add(readerTipo["nombre"].ToString())) ;

            /*lleno el campo Rstado Cuenta*/
            comboBox1.Items.Add("");
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlDataReader reader = DAO.ConexionDB.ejecReaderProc("SUDO.GetEstadosCuenta", parametros);
            for (; reader.Read(); comboBox1.Items.Add(reader["descripcion"].ToString())) ;
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros en el campo Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private bool validarDatos()
        {
            if (textBoxNumero.Text == "" || comboBox1.Text == ""|| comboBoxTipoCuenta.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (modificarCuenta())
                {
                    resetearForm();
                }
                else
                {
                    MessageBox.Show("Nro de cuenta inexistente");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private bool modificarCuenta()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter cuenta = new SqlParameter("@nroCuenta", textBoxNumero.Text);
            parametros.Add(cuenta);
            SqlParameter tipo = new SqlParameter("@tipoCuenta", comboBoxTipoCuenta.Text);
            parametros.Add(tipo);
            SqlParameter estado = new SqlParameter("@estadoCuenta", comboBox1.Text);
            parametros.Add(estado);

            int res = DAO.ConexionDB.ejecNonQueryProc("SUDO.ModificarCuentaAdmin", parametros);

            return res != 0 && res != -1;
        }
    }
}
