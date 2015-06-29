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

namespace PagoElectronico.Facturacion
{
    public partial class FormFacturacion : Form
    {
        int idUser;

        public FormFacturacion(int userId)
        {
            idUser = userId;
            InitializeComponent();
            actualizarItems();
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void FormFacturacion_Load_1(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            actualizarItems();
        }

        private void actualizarItems()
        {
            DGItems.Rows.Clear();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter idCuenta = new SqlParameter("@idUsuario", Convert.ToInt64(idUser));
            parametros.Add(idCuenta);
            SqlDataReader readerItems = DAO.ConexionDB.ejecReaderProc("SUDO.GetTransferenciasAFacturar", parametros);
            for (; readerItems.Read(); )
            {
                DGItems.Rows.Add(readerItems["costo"], readerItems["importe"], readerItems["moneda"], readerItems["nroCuentaOrigen"], readerItems["nroCuentaDest"]);
            }

            DGFactCuentas.Rows.Clear();
            List<SqlParameter> parametrosCuentas = new List<SqlParameter>();
            SqlParameter idCuenta2 = new SqlParameter("@idUsuario", Convert.ToInt64(idUser));
            parametrosCuentas.Add(idCuenta2);
            SqlDataReader readerCuentas = DAO.ConexionDB.ejecReaderProc("SUDO.GetCambiosCuentaAFacturar", parametrosCuentas);
            for (; readerCuentas.Read(); )
            {
                DGFactCuentas.Rows.Add(readerCuentas["nroCuenta"], readerCuentas["importe"], readerCuentas["fecha"], readerCuentas["descripcion"], readerCuentas["importe"]);
            }
        }

        private void botonFacturar_Click(object sender, EventArgs e)
        {

        }
    }
}
