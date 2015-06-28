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

namespace PagoElectronico.Transferencias
{
    public partial class FormTransferencia : Form
    {
        GestorLogin gestorLogin = new GestorLogin();
        ConfigInicial configInicial = new ConfigInicial();
        int idUser;

        public FormTransferencia(int userId)
        {
            InitializeComponent();
            idUser = userId;
            llenarCuenta();
            llenarMoneda();            
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFrom();
        }

        private void limpiarFrom()
        {
            comboBoxCuentaOrigen.SelectedItem = "";
            textBoxImporte.ResetText();
            comboBoxMoneda.SelectedItem = "";
            textBoxCuentaDest.ResetText();            
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void textBoxImporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBoxImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar.ToString() != ","))
            {
                MessageBox.Show("Solo se permiten numeros en el campo Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxCuentaDest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBoxCuentaDest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar.ToString() != ","))
            {
                MessageBox.Show("Solo se permiten numeros en el campo Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void llenarCuenta()//llena el comboBox con las cuentas Habilitadas asociadas al usuario
        {
            SqlDataReader reader = gestorLogin.ConsultarConIdUsuario(idUser, "SUDO.GetCuentas");

            comboBoxCuentaOrigen.Items.Add("");
            for (; reader.Read(); )
            {
                if (reader["descripcion"].ToString() == "Habilitada")
                {
                    comboBoxCuentaOrigen.Items.Add(reader["nroCuenta"].ToString());
                }
            }
        }

        private void llenarMoneda()//llena el comboBox con todas las monedas disponibles
        {
            comboBoxMoneda.Items.Add("");
            List<SqlParameter> parametrosMoneda = new List<SqlParameter>();
            SqlDataReader readerMoneda = DAO.ConexionDB.ejecReaderProc("SUDO.GetMonedas", parametrosMoneda);
            for (; readerMoneda.Read(); comboBoxMoneda.Items.Add(readerMoneda["descripcion"].ToString())) ;
        }

        private void botonTransferir_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (hacerTransferencia())
                {
                    limpiarFrom();
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente o cuenta destino invalida");
                }
            }
            else
            {
                MessageBox.Show("El importe tiene que ser mayor a 1 y los datos tienen que estar completos");
            }
        }

        private bool validarDatos()
        {
            if (comboBoxCuentaOrigen.Text == "" || comboBoxMoneda.Text == "" || textBoxCuentaDest.Text == "")
                return false;
            bool importeMayor1 = Convert.ToDecimal(textBoxImporte.Text) > 1;

            return importeMayor1;
        }

        private bool hacerTransferencia()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter cuentaOrigen = new SqlParameter("@nroCuentaOrigen", comboBoxCuentaOrigen.Text);
            parametros.Add(cuentaOrigen);
            SqlParameter importe = new SqlParameter("@importe", textBoxImporte.Text);
            parametros.Add(importe);
            SqlParameter moneda = new SqlParameter("@moneda", comboBoxMoneda.Text);
            parametros.Add(moneda);
            SqlParameter cuentaDest = new SqlParameter("@nroCuentaDest", textBoxCuentaDest.Text);
            parametros.Add(cuentaDest);
            SqlParameter fecha = new SqlParameter("@fecha", configInicial.GetFecha());
            parametros.Add(fecha);
            
            int res = DAO.ConexionDB.ejecNonQueryProc("SUDO.CrearTransferencia", parametros);

            return res != 0 && res != -1;
        }

    }
}
