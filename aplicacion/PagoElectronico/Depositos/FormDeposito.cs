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

namespace PagoElectronico.Depositos
{
    public partial class FormDeposito : Form
    {
        GestorLogin gestorLogin = new GestorLogin();
        List<long> idTarjetas;
        int idUser;

        public FormDeposito(int userId)
        {
            InitializeComponent();
            idUser = userId;
            //Muestra las cuentas asociadas al usuario
            SqlDataReader reader = gestorLogin.ConsultarConIdUsuario(userId, "SUDO.GetCuentas");
            for (; reader.Read(); comboBox1.Items.Add(reader["nroCuenta"].ToString())) ;

            //Muestra las monedas
            List<SqlParameter> parametrosMoneda = new List<SqlParameter>();
            SqlDataReader readerMoneda = DAO.ConexionDB.ejecReaderProc("SUDO.GetMonedas", parametrosMoneda);
            for (; readerMoneda.Read(); comboBox2.Items.Add(readerMoneda["descripcion"].ToString())) ;

            //Muestra las tarjetas asociadas al usuario
            SqlDataReader readerTarjetas = gestorLogin.ConsultarConIdUsuario(userId, "SUDO.GetTarjetasCliente");
            for (; readerTarjetas.Read(); )
            {
                int RelsultadoComparacionFechas = DateTime.Compare(Convert.ToDateTime(readerTarjetas["fechaVencimiento"]), DateTime.Today);
                if(RelsultadoComparacionFechas >= 0)
                {
                    comboBox3.Items.Add(readerTarjetas["ult4NumTarj"].ToString() + " " + readerTarjetas["descripcion"].ToString());
                    idTarjetas.Add(Convert.ToInt64(readerTarjetas["idTarjeta"]));
                }
                    /*
                else
                {
                    MessageBox.Show("Tarjeta vencida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                     */
            }
            
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter idUsuario = new SqlParameter("@idUsuario", idUser);
            parametros.Add(idUsuario);
            SqlParameter idTarjeta = new SqlParameter("@idTarjeta", idTarjetas[comboBox1.Items.IndexOf()]);
            parametros.Add(idTarjeta);
            SqlParameter moneda = new SqlParameter("@moneda", comboBox2.Text);
            parametros.Add(moneda);
            SqlParameter importe = new SqlParameter("@importe", textBox1.Text);
            parametros.Add(importe);
            SqlParameter fecha = new SqlParameter("@fecha", DateTime.Today);
            parametros.Add(fecha);
            DAO.ConexionDB.ejecScalarProc("SUDO.CrearDeposito", parametros);

            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            textBox1.ResetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros en el campo Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}