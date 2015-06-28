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
            SqlDataReader readerItems = DAO.ConexionDB.ejecReaderProc("SUDO.GetItemsAFacturar", parametros);
            for (; readerItems.Read(); )
            {
                DGItems.Rows.Add(readerItems["descripcion"], readerItems["costo"], readerItems["importe"], readerItems["moneda"], readerItems["nroCuentaOrigen"], readerItems["nroCuentaDest"]);
            }
        }

        private void botonFacturar_Click(object sender, EventArgs e)
        {

        }
    }
}
