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

namespace PagoElectronico.Consulta_Saldos
{
    public partial class FormConsultaSaldo : Form
    {
        GestorLogin gestorLogin = new GestorLogin();

        public FormConsultaSaldo(int idUser)
        {
            InitializeComponent();
            SqlDataReader reader = gestorLogin.ConsultarConIdUsuario(idUser,"SUDO.GetCuentas");

            for (; reader.Read(); comboBox1.Items.Add(reader["nroCuenta"].ToString())) ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultaSaldo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                //muestra el saldo de la cuenta elejida
                SqlDataReader readerSaldo = gestorLogin.ConsultarConIdCuenta(Convert.ToInt64(comboBox1.Text), "SUDO.GetSaldo");
                readerSaldo.Read();
                label2.Text = Convert.ToString(readerSaldo["saldo"]);
                //muestra los 5 ultimos depositos
                DGDepositos.Rows.Clear();
                SqlDataReader readerDeposito = gestorLogin.ConsultarConIdCuenta(Convert.ToInt64(comboBox1.Text), "SUDO.GetUltimos5depositos");

                for (; readerDeposito.Read(); )
                {
                    DGDepositos.Rows.Add(readerDeposito["codigo"], readerDeposito["fecha"], readerDeposito["importe"], readerDeposito["ult4NumTarj"]);
                }

                //muestra los 5 ultimos retiros
                DGRetiros.Rows.Clear();
                SqlDataReader readerRetiro = gestorLogin.ConsultarConIdCuenta(Convert.ToInt64(comboBox1.Text), "SUDO.GetUltimos5Retiros");

                for (; readerRetiro.Read(); )
                {
                    DGRetiros.Rows.Add(readerRetiro["codigo"], readerRetiro["fecha"], readerRetiro["importe"], readerRetiro["idCheque"]);
                }
                //muestra las 10 ultimas transferencias de fondos
                DGTransferencias.Rows.Clear();
                SqlDataReader readerTransferencias = gestorLogin.ConsultarConIdCuenta(Convert.ToInt64(comboBox1.Text), "SUDO.GetUltimas10Transferencias");

                for (; readerTransferencias.Read(); )
                {
                    DGTransferencias.Rows.Add(readerTransferencias["idTrans"], readerTransferencias["fecha"], readerTransferencias["importe"], readerTransferencias["costo"], readerTransferencias["nroCuentaDest"]);
                }

            }
            else
            {
                MessageBox.Show("Elija una cuenta");
            }
        }

        private void DGDepositos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGRetiros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGTransferencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
