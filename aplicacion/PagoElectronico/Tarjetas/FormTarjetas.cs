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
    public partial class FormTarjetas : Form
    {
        int idUser;
        public FormTarjetas(int userId)
        {
            idUser = userId;
            InitializeComponent();
            //Muestra las tarjetas asociadas al usuario
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter idCuenta = new SqlParameter("@idUsuario", Convert.ToInt64(idUser));
            parametros.Add(idCuenta);
            SqlDataReader readerTarjetas = DAO.ConexionDB.ejecReaderProc("SUDO.GetTarjetas", parametros);
            for (; readerTarjetas.Read(); )
            {
                DGTarjetas.Rows.Add(readerTarjetas["ult4NumTarj"], readerTarjetas["fechaEmision"], readerTarjetas["fechaVencimiento"], readerTarjetas["descripcion"], readerTarjetas["estado"]);
            }
            
        }

        private void FormTarjetas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Muestra las tarjetas asociadas al usuario
            DGTarjetas.Rows.Clear();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter idCuenta = new SqlParameter("@idUsuario", Convert.ToInt64(idUser));
            parametros.Add(idCuenta);
            SqlDataReader readerTarjetas = DAO.ConexionDB.ejecReaderProc("SUDO.GetTarjetas", parametros);
            for (; readerTarjetas.Read(); )
            {
                DGTarjetas.Rows.Add(readerTarjetas["ult4NumTarj"], readerTarjetas["fechaEmision"], readerTarjetas["fechaVencimiento"], readerTarjetas["descripcion"], readerTarjetas["estado"]);
            }
        }

        private void DGTarjetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
