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

namespace PagoElectronico.Depositos
{
    public partial class FormDeposito : Form
    {
        GestorLogin gestorLogin = new GestorLogin();
        ConfigInicial configInicial = new ConfigInicial();
        List<long> idTarjetas = new List<long>();
        int idUser;

        public FormDeposito(int userId)
        {
            InitializeComponent();
            idUser = userId;
            llenarCuenta();
            llenarMoneda();
            llenarTarjeta();            
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFrom();
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

        private void botonDepositar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (hacerDeposito())
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
                MessageBox.Show("El importe tiene que ser mayor a 1 y los datos tienen que estar completos");
            }
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

        private void llenarMoneda()//llena el comboBox con todas las monedas disponibles
        {
            comboBoxMoneda.Items.Add("");
            List<SqlParameter> parametrosMoneda = new List<SqlParameter>();
            SqlDataReader readerMoneda = DAO.ConexionDB.ejecReaderProc("SUDO.GetMonedas", parametrosMoneda);
            for (; readerMoneda.Read(); comboBoxMoneda.Items.Add(readerMoneda["descripcion"].ToString())) ;
        }

        private void llenarTarjeta()//llena el comboBox con todas las tarjetas asociadas al usuario
        {
            SqlDataReader readerTarjetas = gestorLogin.ConsultarConIdUsuario(idUser, "SUDO.GetTarjetasCliente");
            comboBoxTarjCred.Items.Add("");
            for (; readerTarjetas.Read(); )
            {
                int relsultadoComparacionFechas = DateTime.Compare(Convert.ToDateTime(readerTarjetas["fechaVencimiento"]), configInicial.GetFecha());
                if (relsultadoComparacionFechas >= 0)
                {
                    comboBoxTarjCred.Items.Add(readerTarjetas["ult4num"].ToString() + " " + readerTarjetas["descripcion"].ToString());
                    idTarjetas.Add(Convert.ToInt64(readerTarjetas["idTarjeta"]));
                }
            }
        }

        private bool hacerDeposito()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
           
            SqlParameter idTarjeta = new SqlParameter("@idTarjeta", idTarjetas[comboBoxTarjCred.Items.IndexOf(comboBoxTarjCred.Text)-1]);
            parametros.Add(idTarjeta);
            SqlParameter moneda = new SqlParameter("@moneda", comboBoxMoneda.Text);
            parametros.Add(moneda);
            SqlParameter importe = new SqlParameter("@importe", textBoxImporte.Text);
            parametros.Add(importe);
            SqlParameter fecha = new SqlParameter("@fecha", configInicial.GetFecha());
            parametros.Add(fecha);
            SqlParameter cuenta = new SqlParameter("@nroCuenta", comboBoxCuenta.Text);
            parametros.Add(cuenta);
            int res = DAO.ConexionDB.ejecNonQueryProc("SUDO.CrearDeposito", parametros);

            return res != 0 && res != -1; 
        }

        private bool validarDatos()
        {
            if (comboBoxCuenta.Text == "" || comboBoxMoneda.Text == "" || comboBoxTarjCred.Text == "")
                return false;
            bool importeMayor1 = Convert.ToDecimal(textBoxImporte.Text) > 1;

            return importeMayor1;
        }

        private void limpiarFrom()
        {
            comboBoxCuenta.SelectedItem = "";
            comboBoxMoneda.SelectedItem = "";
            comboBoxTarjCred.SelectedItem = "";
            textBoxImporte.ResetText();
        }
    }
}