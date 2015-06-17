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

namespace PagoElectronico.Retiros
{
    public partial class FormRetiro : Form
    {
        GestorLogin gestorLogin = new GestorLogin();
        ConfigInicial configInicial = new ConfigInicial();
        int idUser;

        public FormRetiro(int userId)
        {
            InitializeComponent();
            idUser = userId;
            llenarCuenta();
            llenarMoneda();
            llenarBanco();
        }

        private void FormRetiro_Load(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFrom();
        }

        private void limpiarFrom()
        {
            comboBoxCuenta.SelectedItem = "";
            comboBoxMoneda.SelectedItem = "";
            textBoxImporte.ResetText();
            textBoxNroDoc.ResetText();
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
        private void textBoxNroDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBoxNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros en el campo Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void llenarMoneda()//llena el comboBox con todas las monedas disponibles
        {
            comboBoxMoneda.Items.Add("");
            List<SqlParameter> parametrosMoneda = new List<SqlParameter>();
            SqlDataReader readerMoneda = DAO.ConexionDB.ejecReaderProc("SUDO.GetMonedas", parametrosMoneda);
            for (; readerMoneda.Read(); comboBoxMoneda.Items.Add(readerMoneda["descripcion"].ToString())) ;
        }

        private void llenarBanco()//llena el comboBox con todas los bancos disponibles
        {
            comboBoxBanco.Items.Add("");
            List<SqlParameter> parametrosBanco = new List<SqlParameter>();
            SqlDataReader readerBanco = DAO.ConexionDB.ejecReaderProc("SUDO.GetBancos", parametrosBanco);
            for (; readerBanco.Read(); comboBoxBanco.Items.Add(readerBanco["nombre"].ToString())) ;
        }

        private void llenarCuenta()//llena el comboBox con las cuentas Habilitadas asociadas al usuario
        {
            SqlDataReader reader = gestorLogin.ConsultarConIdUsuario(idUser, "SUDO.GetCuentas");
            comboBoxCuenta.Items.Add("");

            for (; reader.Read(); )
            {
                if (reader["descripcion"].ToString() == "Habilitada")
                {
                    comboBoxCuenta.Items.Add(reader["nroCuenta"].ToString());
                }
            }
        }

        private void botonRetirar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (hacerRetiro())
                {
                    limpiarFrom();
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }
            }
            else
            {
                MessageBox.Show("El importe tiene que ser mayor a 1 y los datos tienen que estar completos, tambien puede ser que el numero de documento este incorecto");
            }
        }

        private bool validarDatos()
        {
            if (comboBoxCuenta.Text == "" || comboBoxMoneda.Text == "" || textBoxNroDoc.Text == "" || comboBoxBanco.Text == "")
                return false;
            bool importeMayor1 = Convert.ToDecimal(textBoxImporte.Text) > 1;

            return importeMayor1;
        }

        private bool hacerRetiro()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            
            SqlParameter cuenta = new SqlParameter("@nroCuenta", comboBoxCuenta.Text);
            parametros.Add(cuenta);
            SqlParameter fecha = new SqlParameter("@fecha", configInicial.GetFecha());
            parametros.Add(fecha);
            SqlParameter moneda = new SqlParameter("@moneda", comboBoxMoneda.Text);
            parametros.Add(moneda);
            SqlParameter importe = new SqlParameter("@importe", textBoxImporte.Text);
            parametros.Add(importe);
            SqlParameter banco = new SqlParameter("@nombreBanco", comboBoxBanco.Text);
            parametros.Add(banco);
            SqlParameter nroDoc = new SqlParameter("@nroDoc", textBoxNroDoc.Text);
            parametros.Add(nroDoc);
            
            int res = DAO.ConexionDB.ejecNonQueryProc("SUDO.CrearRetiro", parametros);
            
            return res != 0 && res != -1;
        }
    }
}
