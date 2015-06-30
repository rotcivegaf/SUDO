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
    public partial class FormCuentaAlta : Form
    {
        public FormCuentaAlta()
        {
            InitializeComponent();
            llenarCampos();
        }

        private void botomVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void textBoxImporte_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros en el campo Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void resetearForm()
        {
            comboBoxPais.ResetText();
            comboBoxMoneda.ResetText();
            comboBoxTipoCuenta.ResetText();
            textBoxNumero.Text="";
        }

        private void llenarCampos()
        {
            /*lleno el campo moneda*/
            comboBoxMoneda.Items.Add("");
            List<SqlParameter> parametrosMoneda = new List<SqlParameter>();
            SqlDataReader readerMoneda = DAO.ConexionDB.ejecReaderProc("SUDO.GetMonedas", parametrosMoneda);
            for (; readerMoneda.Read(); comboBoxMoneda.Items.Add(readerMoneda["descripcion"].ToString())) ;
            
            /*lleno el campo Pais*/
            comboBoxPais.Items.Add("");
            List<SqlParameter> parametrosPais = new List<SqlParameter>();
            SqlDataReader readerPais = DAO.ConexionDB.ejecReaderProc("SUDO.GetPaises", parametrosPais);
            for (; readerPais.Read(); comboBoxPais.Items.Add(readerPais["descripcion"].ToString())) ;
            
            /*lleno el campo tipo cuenta*/
            comboBoxTipoCuenta.Items.Add("");
            List<SqlParameter> parametrosTipo = new List<SqlParameter>();
            SqlDataReader readerTipo = DAO.ConexionDB.ejecReaderProc("SUDO.GetTiposCuenta", parametrosTipo);
            for (; readerTipo.Read(); comboBoxTipoCuenta.Items.Add(readerTipo["nombre"].ToString())) ;
        }

        private bool validarDatos()
        {
            if(textBoxNumero.Text == "" || comboBoxMoneda.Text == "" || comboBoxPais.Text == "" || comboBoxTipoCuenta.Text == ""){
                return false;
            }
            else
            {
                return true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botomAlta_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (altaCuenta())
                {
                    resetearForm();
                }
                else
                {
                    MessageBox.Show("Nro de cuenta existente o idUsuario inexistente");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            
        }

        private bool altaCuenta()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter cuenta = new SqlParameter("@nroCuenta", textBoxNumero.Text);
            parametros.Add(cuenta);
            SqlParameter idUsuario = new SqlParameter("@idUsuario", textBoxIdUsuario.Text);
            parametros.Add(idUsuario);
            SqlParameter moneda = new SqlParameter("@moneda", comboBoxMoneda.Text);
            parametros.Add(moneda);
            SqlParameter pais = new SqlParameter("@pais", comboBoxPais.Text);
            parametros.Add(pais);
            SqlParameter tipo = new SqlParameter("@tipoCuenta", comboBoxTipoCuenta.Text);
            parametros.Add(tipo);
            SqlParameter fecha = new SqlParameter("@fechaApertura", dateTimePickerFecha.Value);
            parametros.Add(fecha);

            int res = DAO.ConexionDB.ejecNonQueryProc("SUDO.CrearCuenta", parametros);

            return res != 0 && res != -1;
        }

        private void FormCuentaAlta_Load(object sender, EventArgs e)
        {

        }        
    }
}
