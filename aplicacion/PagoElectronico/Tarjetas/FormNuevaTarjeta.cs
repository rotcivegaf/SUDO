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

namespace PagoElectronico.Tarjetas
{
    public partial class FormNuevaTarjeta : Form
    {
        int idUser;

        public FormNuevaTarjeta(int userId)
        {
            idUser = userId;
            InitializeComponent();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlDataReader readerEmisores = DAO.ConexionDB.ejecReaderProc("SUDO.GetEmisores", parametros);

            for (; readerEmisores.Read(); EmisorTarjetaCombobox.Items.Add(readerEmisores["descripcion"].ToString())) ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void EmisorTarjetaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter paramentroNumero = new SqlParameter("@numero", textBox1.Text);
            parametros.Add(paramentroNumero);
            bool ExisteNumeroTarjeta = DAO.ConexionDB.ejecNonQueryProc("SUDO.ExisteNumeroTarjeta", parametros) != 1;

            if ((ExisteNumeroTarjeta) && (textBox2.Text != "") && (textBox1.Text != "") && (EmisorTarjetaCombobox.Text != ""))
            {
                List<SqlParameter> parametrosAsociar = new List<SqlParameter>();
                SqlParameter numero = new SqlParameter("@numero", textBox1.Text);
                parametrosAsociar.Add(numero);
                SqlParameter emisor = new SqlParameter("@emisorDesc", EmisorTarjetaCombobox.Text);
                parametrosAsociar.Add(emisor);
                SqlParameter fechaEmision = new SqlParameter("@fechaEmision", dateTimePickerUM.Value);
                parametrosAsociar.Add(fechaEmision);
                SqlParameter fechaVencimiento = new SqlParameter("@fechaVencimiento", dateTimePicker1.Value);
                parametrosAsociar.Add(fechaVencimiento);
                SqlParameter codigoSeguridad = new SqlParameter("@codigoSeguridad", textBox2.Text);
                parametrosAsociar.Add(codigoSeguridad);
                SqlParameter codigoIdUser = new SqlParameter("@idUser", idUser);
                parametrosAsociar.Add(codigoIdUser);
                DAO.ConexionDB.ejecScalarProc("SUDO.AsociarTarjeta", parametrosAsociar);
            }
            else
            {
                MessageBox.Show("Numero de tarjeta existente o datos incompletos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNuevaTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerUM_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
