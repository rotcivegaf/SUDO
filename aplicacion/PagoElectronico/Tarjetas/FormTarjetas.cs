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
                DGTarjetas.Rows.Add(readerTarjetas["idTarjeta"], readerTarjetas["ult4NumTarj"], readerTarjetas["fechaEmision"], readerTarjetas["fechaVencimiento"], readerTarjetas["descripcion"], readerTarjetas["estado"]);
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
                DGTarjetas.Rows.Add(readerTarjetas["idTarjeta"], readerTarjetas["ult4NumTarj"], readerTarjetas["fechaEmision"], readerTarjetas["fechaVencimiento"], readerTarjetas["descripcion"], readerTarjetas["estado"]);
            }
        }

        private void DGTarjetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DGTarjetas.SelectedRows.Count == 1)
            {
                long idTarjeta = Convert.ToInt64(DGTarjetas.SelectedCells[0].Value);
                List<SqlParameter> parametrosDesasociar = new List<SqlParameter>();
                SqlParameter parametroIdTarjeta = new SqlParameter("@idTarjeta", idTarjeta);
                parametrosDesasociar.Add(parametroIdTarjeta);
                DAO.ConexionDB.ejecScalarProc("SUDO.DesasociarTarjeta", parametrosDesasociar);
                button4.PerformClick();
            }
            else
            {
                MessageBox.Show("Seleccione solamente una fila");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNuevaTarjeta formNuevaTarjeta = new FormNuevaTarjeta(idUser);
            formNuevaTarjeta.Show(this);
            this.Hide();
        }
    }
}
