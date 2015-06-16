using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using PagoElectronico.DAO;
using PagoElectronico.Utils;

namespace PagoElectronico.Tarjetas
{
    public partial class FormNuevaTarjeta : Form
    {
        int idUser;
        ConfigInicial configInicial = new ConfigInicial();

        public FormNuevaTarjeta(int userId)
        {
            idUser = userId;
            InitializeComponent();
            limpiarFrom();
            llenarComboEmisores();
        }

        private void FormNuevaTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
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

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void botonAsociar_Click(object sender, EventArgs e)
        {
            if ((textBoxCod.Text != "") && (textBoxNumero.Text != "") && (comboBoxEmisor.Text != ""))
            {
                if (asociarTarjeta())
                {
                    limpiarFrom();
                }
                else
                {
                    MessageBox.Show("Numero de tarjeta existente");
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFrom();
        }

        private void llenarComboEmisores()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlDataReader readerEmisores = DAO.ConexionDB.ejecReaderProc("SUDO.GetEmisores", parametros);

            for (; readerEmisores.Read(); comboBoxEmisor.Items.Add(readerEmisores["descripcion"].ToString())) ;
        }

        private void limpiarFrom()
        {
            textBoxNumero.ResetText();
            textBoxCod.ResetText();
            comboBoxEmisor.Text = "";
            dateTimePickerVencimiento.Value = configInicial.GetFecha();
            dateTimePickerEmision.Value = configInicial.GetFecha();
        }

        private bool asociarTarjeta()
        {
            List<SqlParameter> parametrosAsociar = new List<SqlParameter>();
            SqlParameter numero = new SqlParameter("@numero", textBoxNumero.Text);
            parametrosAsociar.Add(numero);
            SqlParameter emisor = new SqlParameter("@emisorDesc", comboBoxEmisor.Text);
            parametrosAsociar.Add(emisor);
            SqlParameter fechaEmision = new SqlParameter("@fechaEmision", dateTimePickerEmision.Value);
            parametrosAsociar.Add(fechaEmision);
            SqlParameter fechaVencimiento = new SqlParameter("@fechaVencimiento", dateTimePickerVencimiento.Value);
            parametrosAsociar.Add(fechaVencimiento);
            SqlParameter codigoSeguridad = new SqlParameter("@codigoSeguridad", textBoxCod.Text);
            parametrosAsociar.Add(codigoSeguridad);
            SqlParameter codigoIdUser = new SqlParameter("@idUser", idUser);
            parametrosAsociar.Add(codigoIdUser);

            int res = DAO.ConexionDB.ejecNonQueryProc("SUDO.AsociarTarjeta", parametrosAsociar);

            return res != 0;
        }
    }
}
