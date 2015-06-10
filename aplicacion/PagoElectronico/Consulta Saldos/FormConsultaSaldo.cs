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

namespace PagoElectronico.Consulta_Saldos
{
    public partial class FormConsultaSaldo : Form
    {
        public FormConsultaSaldo(int idUser)
        {
            InitializeComponent();

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter userId = new SqlParameter("@idUsuario", idUser);
            parametros.Add(userId);
            SqlDataReader reader = DAO.ConexionDB.ejecReaderProc("SUDO.GetCuentas", parametros);

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
                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter idCuenta = new SqlParameter("@nroCuenta", Convert.ToInt64(comboBox1.Text));
                parametros.Add(idCuenta);
                SqlDataReader readerSaldo = DAO.ConexionDB.ejecReaderProc("SUDO.GetSaldo", parametros);
                readerSaldo.Read();
                label2.Text = Convert.ToString(readerSaldo["saldo"]);
                //muestra los 5 ultimos depositos
                DGDepositos.Rows.Clear();

                List<SqlParameter> parametros2 = new List<SqlParameter>();
                SqlParameter idCuenta2 = new SqlParameter("@nroCuenta", Convert.ToInt64(comboBox1.Text));
                parametros2.Add(idCuenta2);
                SqlDataReader readerDeposito = DAO.ConexionDB.ejecReaderProc("SUDO.GetUltimos5depositos", parametros2);

                for (; readerDeposito.Read(); )
                {
                    DGDepositos.Rows.Add(readerDeposito["codigo"], readerDeposito["fecha"], readerDeposito["importe"], readerDeposito["ult4NumTarj"]);
                }

                //muestra los 5 ultimos retiros
                List<SqlParameter> parametros3 = new List<SqlParameter>();
                SqlParameter idCuenta3 = new SqlParameter("@nroCuenta", Convert.ToInt64(comboBox1.Text));
                parametros3.Add(idCuenta3);
                SqlDataReader readerRetiro = DAO.ConexionDB.ejecReaderProc("SUDO.GetUltimos5Retiros", parametros3);

                for (; readerRetiro.Read(); )
                {
                    DGRetiros.Rows.Add(readerRetiro["codigo"], readerRetiro["fecha"], readerRetiro["importe"], readerRetiro["idCheque"]);
                }
                //muestra las 10 ultimas transferencias de fondos
                List<SqlParameter> parametros4 = new List<SqlParameter>();
                SqlParameter idCuenta4 = new SqlParameter("@nroCuenta", Convert.ToInt64(comboBox1.Text));
                parametros4.Add(idCuenta4);
                SqlDataReader readerTransferencias = DAO.ConexionDB.ejecReaderProc("SUDO.GetUltimas10Transferencias", parametros4);

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
